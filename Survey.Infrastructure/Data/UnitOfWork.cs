using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Repositories;
using Surveys.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SurveyContext _context;
        public ISurveyRepository SurveyRepository { get; }

        public IVersionRepository VersionRepository { get; }

        public IQuestionRepository QuestionRepository { get; }

        public IOptionRepository OptionRepository { get; }

        public IAnswerRepository AnswerRepository { get; }

        public IAnswerTypeRepository AnswerTypeRepository { get; }

        public UnitOfWork(SurveyContext context)
        {
            _context = context;
            SurveyRepository = new SurveyRepository(context);
            VersionRepository = new VersionRepository(context);
            QuestionRepository = new QuestionRepository(context);
            OptionRepository = new OptionRepository(context);
            AnswerRepository = new AnswerRepository(context);
            AnswerTypeRepository = new AnswerTypeRepository(context);
        }       

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChange(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
