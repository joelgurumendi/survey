using AutoMapper;
using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using Surveys.Domain.Surveys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Shared.Domain.Specifications;

namespace Surveys.Application.Surveys.Handlers.Surveys
{
    internal class GetAllSurveyHandler : IRequestHandler<GetAllSurveyQuery, IEnumerable<SurveyVersionResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;
        public GetAllSurveyHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<SurveyVersionResponse>> Handle(GetAllSurveyQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Survey> surveysFound;
            var domainService = new DomainService<Survey>(_repository.SurveyRepository);
            if (request.Role == RolesName.INTERVIEWER)
            {
                surveysFound = await domainService.GetByUserId(request.CreatedBy, cancellationToken);
                return _mapper.Map<IEnumerable<SurveyVersionResponse>>(surveysFound);
            }
            surveysFound = await domainService.GetAll(cancellationToken);
            var surveyVersion = _mapper.Map<IEnumerable<SurveyVersionResponse>>(surveysFound);
            return surveyVersion.Select(survey => new SurveyVersionResponse { Id = survey.Id, Description = survey.Description, Name = survey.Name, Versions = new List<VersionResponse>() { survey.Versions.MaxBy(version => version.To) } });
        }
    }
}
