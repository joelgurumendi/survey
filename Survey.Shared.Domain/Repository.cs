using System.Linq.Expressions;

namespace Surveys.Shared.Domain
{
    public interface IRepository<T> where T : Entity
    {
        Task Add(T entity, CancellationToken cancellationToken);
        Task AddRange(IEnumerable<T> entities, CancellationToken cancellationToken);
        Task<T?> FindByCriteria(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task<IEnumerable<T>> FindManyByCriteria(Expression<Func<T, bool>> expression, CancellationToken cancellationToken);
        Task SaveChange(CancellationToken cancellationToken);
    }
}
