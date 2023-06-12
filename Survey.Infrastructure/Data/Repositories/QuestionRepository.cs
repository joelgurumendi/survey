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
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SurveyContext _context;

        public QuestionRepository(SurveyContext context)
        {
            _context = context;
        }

        public async Task Add(Question entity, CancellationToken cancellationToken)
        {
            await _context.Questions.AddAsync(entity, cancellationToken);
        }

        public async Task AddRange(IEnumerable<Question> entity, CancellationToken cancellationToken)
        {
            await _context.Questions.AddRangeAsync(entity, cancellationToken);
        }

        public async Task<Question?> FindByCriteria(Expression<Func<Question, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Questions.Include(x => x.Options).Where(expression).SingleOrDefaultAsync(cancellationToken);
        }

        public async Task<IEnumerable<Question>> FindManyByCriteria(Expression<Func<Question, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Questions.Include(x => x.Options).Where(expression).ToListAsync(cancellationToken);
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
