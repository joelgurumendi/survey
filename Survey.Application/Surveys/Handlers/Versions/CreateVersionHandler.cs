using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Specifications;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Application.Surveys.Handlers.Versions
{
    internal class CreateVersionHandler : IRequestHandler<CreateVersionCommand, Guid>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        public CreateVersionHandler(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateVersionCommand request, CancellationToken cancellationToken)
        {
            var version = _mapper.Map<Version>(request);
            var expresion = new FindVersionBySurveyIdAndNameSpecification(request.SurveyId, request.Name).And(new IsNotDeletedSpecification<Version>()).ToExpression();
            var versionFound = await _repository.VersionRepository.FindByCriteria(expresion, cancellationToken);
            if (versionFound != null) throw new VersionAlreadyExistsException();
            await _repository.VersionRepository.Add(version, cancellationToken);
            await _repository.SaveChange(cancellationToken);
            return version.Id;
        }
    }
}
