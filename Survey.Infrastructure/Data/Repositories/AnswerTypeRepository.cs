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
    public class AnswerTypeRepository : IAnswerTypeRepository
    {
        private readonly SurveyContext _context;
        public AnswerTypeRepository(SurveyContext context)
        {
            _context = context;
        }
        public async Task Add(AnswerType entity, CancellationToken cancellationToken)
        {
            await _context.TypeAnswers.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<AnswerType> entities, CancellationToken cancellationToken)
        {
            await _context.TypeAnswers.AddRangeAsync(entities, cancellationToken);
        }

        public async Task<AnswerType?> FindByCriteria(Expression<Func<AnswerType, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.TypeAnswers.Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<AnswerType>> FindManyByCriteria(Expression<Func<AnswerType, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.TypeAnswers.Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
