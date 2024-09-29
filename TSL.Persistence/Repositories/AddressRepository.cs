using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Application.Contracts.Persistence;
using Tracker.Domain;
using TSL.Persistence.DatabaseContext;

namespace TSL.Persistence.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(LiveDatabaseContext context) : base(context)
        {
        }
    }
}
