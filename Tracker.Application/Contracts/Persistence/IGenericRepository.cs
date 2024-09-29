using System.Linq.Expressions;
using Tracker.Application.Common;
using Tracker.Domain.Common;

namespace Tracker.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
    }
}
