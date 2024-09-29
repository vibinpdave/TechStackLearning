using Tracker.Application.Contracts.Persistence;
using Tracker.Domain;
using TSL.Persistence.DatabaseContext;

namespace TSL.Persistence.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(LiveDatabaseContext context) : base(context)
        {
        }
    }
}
