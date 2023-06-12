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

namespace Surveys.Application.Surveys.Handlers.Options
{
    internal class DeleteOptionHandler : IRequestHandler<DeleteOptionCommand>
    {
        private readonly IUnitOfWork _repository;
        public DeleteOptionHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteOptionCommand request, CancellationToken cancellationToken)
        {
            var version = await new DomainService<Option>(_repository.OptionRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            version.Delete();
            await _repository.SaveChange(cancellationToken);
        }
    }
}
