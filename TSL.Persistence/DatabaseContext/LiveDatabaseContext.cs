using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tracker.Domain;
using Tracker.Domain.Common;

namespace TSL.Persistence.DatabaseContext
{
    public class LiveDatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public LiveDatabaseContext(DbContextOptions<LiveDatabaseContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations from the assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LiveDatabaseContext).Assembly);
            // Add prefix to all table names
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entity.GetTableName();
                entity.SetTableName(_configuration["DatabasePrefix"] + tableName);
            }
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
