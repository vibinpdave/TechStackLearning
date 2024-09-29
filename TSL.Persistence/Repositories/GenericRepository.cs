using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tracker.Application.Common;
using Tracker.Application.Contracts.Persistence;
using Tracker.Domain.Common;
using TSL.Persistence.DatabaseContext;

namespace TSL.Persistence.Repositories
{
    public class GenericRepository<T> : BaseRepository<T>, IGenericRepository<T> where T : BaseEntity
    {
        public GenericRepository(LiveDatabaseContext context) : base(context)
        {
        }
    }
}
