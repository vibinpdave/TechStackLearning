using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tracker.Application.Contracts.Persistence;
using TSL.Persistence.DatabaseContext;
using TSL.Persistence.Repositories;

namespace TSL.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<LiveDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LiveDatabaseConnectionString"));
            });
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            return services;
        }
    }
}
