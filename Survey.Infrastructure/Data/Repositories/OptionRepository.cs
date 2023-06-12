using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Data.Repositories
{
    public class OptionRepository : IOptionRepository
    {
        private readonly SurveyContext _context;
        public OptionRepository(SurveyContext context)
        {
            _context = context;
        }
        public async Task Add(Option entity, CancellationToken cancellationToken)
        {
            await _context.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<Option> entities, CancellationToken cancellationToken)
        {
            await _context.AddRangeAsync(entities, cancellationToken);
        }

        public async Task<Option?> FindByCriteria(Expression<Func<Option, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Options.Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Option>> FindManyByCriteria(Expression<Func<Option, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Options.Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
