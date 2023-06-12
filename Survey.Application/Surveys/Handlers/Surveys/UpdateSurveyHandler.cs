using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain.Specifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Application.Surveys.Handlers.Surveys
{
    internal class UpdateSurveyHandler : IRequestHandler<UpdateSurveyCommand>
    {
        private readonly IUnitOfWork _repository;
        public UpdateSurveyHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey = await new DomainService<Survey>(_repository.SurveyRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            survey.Name = request.Name;
            survey.Description = request.Description;
            survey.Update();
            var version = new Version(request.VersionName, survey.Id, DateTime.UtcNow, DateTime.UtcNow.AddDays(10), request.CreatedBy);
            var versionExpresion = new FindVersionBySurveyIdAndNameSpecification(version.Id, version.Name).And(new IsNotDeletedSpecification<Version>()).ToExpression();
            var versionFound = await _repository.VersionRepository.FindByCriteria(versionExpresion, cancellationToken);
            if (versionFound != null) throw new VersionAlreadyExistsException();
            await _repository.VersionRepository.Add(version, cancellationToken);
            foreach (var q in request.Questions)
            {
                var question = new Question(q.AnswerTypeId, version.Id, q.Label, q.Order, q.Required, request.CreatedBy);
                await _repository.QuestionRepository.Add(question, cancellationToken);
                if (q.Options != null)
                    foreach (var opt in q.Options)
                    {
                        var option = new Option(question.Id, opt.Label, opt.Order, request.CreatedBy);
                        await _repository.OptionRepository.Add(option, cancellationToken);
                    }
            }
            await _repository.SaveChange(cancellationToken);
        }
    }
}
