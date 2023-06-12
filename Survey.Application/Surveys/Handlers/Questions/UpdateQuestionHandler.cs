using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Surveys.Domain.Surveys;

namespace Surveys.Application.Surveys.Handlers.Questions
{
    internal class UpdateQuestionHandler : IRequestHandler<UpdateQuestionCommand>
    {
        private readonly IUnitOfWork _repository;
        public UpdateQuestionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var survey = await new DomainService<Question>(_repository.QuestionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            survey.AnswerTypeId = request.AnswerTypeId;
            survey.VersionId = request.VersionId;
            survey.Label = request.Label;
            survey.Order = request.Order;
            survey.Required = request.Required;
            survey.Update();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
