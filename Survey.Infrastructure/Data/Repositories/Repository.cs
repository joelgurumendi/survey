using Surveys.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Surveys.Infrastructure.Data.Repsitories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly SurveyContext _context;

        public Repository(SurveyContext context)
        {
            _context = context;
        }

        public async Task Add(T entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<T> entity, CancellationToken cancellationToken)
        {
            await _context.Set<T>().AddRangeAsync(entity, cancellationToken);
        }

        public async Task<T?> FindByCriteria(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<T>> FindManyByCriteria(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
