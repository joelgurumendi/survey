using Surveys.Domain.Surveys.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys
{
    public interface IUnitOfWork : IDisposable
    {
        ISurveyRepository SurveyRepository { get; }
        IVersionRepository VersionRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IOptionRepository OptionRepository { get; }
        IAnswerRepository AnswerRepository { get; }
        IAnswerTypeRepository AnswerTypeRepository { get; }
        Task SaveChange(CancellationToken cancellationToken);
    }
}
