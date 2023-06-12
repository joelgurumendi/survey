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
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Application.Surveys.Handlers.Versions
{
    internal class UpdateVersionHandler : IRequestHandler<UpdateVersionCommand>
    {
        private readonly IUnitOfWork _repository;
        public UpdateVersionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateVersionCommand request, CancellationToken cancellationToken)
        {
            var survey = await new DomainService<Version>(_repository.VersionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            survey.Name = request.Name;
            survey.To = request.To;
            survey.Update();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
