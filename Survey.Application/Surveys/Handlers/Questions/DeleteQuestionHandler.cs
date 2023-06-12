using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surveys.Domain.Surveys;

namespace Surveys.Application.Surveys.Handlers.Questions
{
    internal class DeleteQuestionHandler : IRequestHandler<DeleteQuestionCommand>
    {
        private readonly IUnitOfWork _repository;
        public DeleteQuestionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = await new DomainService<Question>(_repository.QuestionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            question.Delete();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
