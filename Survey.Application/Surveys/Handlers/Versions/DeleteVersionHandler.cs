using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Application.Surveys.Handlers.Versions
{
    internal class DeleteVersionHandler : IRequestHandler<DeleteVersionCommand>
    {
        private readonly IUnitOfWork _repository;
        public DeleteVersionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteVersionCommand request, CancellationToken cancellationToken)
        {
            var version = await new DomainService<Version>(_repository.VersionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            version.Delete();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
