using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Repositories;
using Surveys.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Data.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly SurveyContext _context;
        public SurveyRepository(SurveyContext context)
        {
            _context = context;
        }
        public async Task Add(Survey entity, CancellationToken cancellationToken)
        {
            await _context.Surveys.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<Survey> entity, CancellationToken cancellationToken)
        {
            await _context.Surveys.AddRangeAsync(entity, cancellationToken);
        }

        public async Task<Survey?> FindByCriteria(Expression<Func<Survey, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Surveys.Include(x => x.Versions).ThenInclude(x => x.Questions).Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Survey>> FindManyByCriteria(Expression<Func<Survey, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Surveys.Include(x => x.Versions).Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
