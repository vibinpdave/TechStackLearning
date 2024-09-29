using System.Linq.Expressions;
using Tracker.Application.Common;

namespace Tracker.Application.Contracts.Persistence
{
    public interface IBaseRepository<T>
    {
        Task<IReadOnlyList<T>> GetAllAsync(
        Expression<Func<T, bool>>? predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string? includeString = null,
        bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            List<Expression<Func<T, object>>>? includes = null,
            bool disableTracking = true);

        Task<PaginatedList<T>> GetPagedResponseAsync(
            int pageNumber,
            int pageSize,
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            List<Expression<Func<T, object>>>? includes = null,
            bool disableTracking = true);

        Task<T> GetByIdAsync(int id);
        Task<int> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
