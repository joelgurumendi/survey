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
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SurveyContext _context;

        public AnswerRepository(SurveyContext context)
        {
            _context = context;
        }

        public async Task Add(Answer entity, CancellationToken cancellationToken)
        {
            await _context.Answers.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<Answer> entities, CancellationToken cancellationToken)
        {
            await _context.Answers.AddRangeAsync(entities, cancellationToken);
        }

        public async Task<Answer?> FindByCriteria(Expression<Func<Answer, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Answers.Include(x => x.Option).Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Answer>> FindManyByCriteria(Expression<Func<Answer, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Answers.Include(x => x.Option).Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
