using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Surveys.Application.Surveys.Handlers.Surveys
{
    internal class DeleteSurveyHandler : IRequestHandler<DeleteSurveyCommand>
    {
        private readonly IUnitOfWork _repository;
        public DeleteSurveyHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey = await new DomainService<Survey>(_repository.SurveyRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            survey.Delete();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
