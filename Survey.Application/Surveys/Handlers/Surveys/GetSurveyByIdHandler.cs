using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Surveys.Domain.Surveys.Exceptions;

namespace Surveys.Application.Surveys.Handlers.Surveys
{
    internal class GetSurveyByIdHandler : IRequestHandler<GetSurveyByIdQuery, SurveyResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;
        public GetSurveyByIdHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<SurveyResponse> Handle(GetSurveyByIdQuery request, CancellationToken cancellationToken)
        {
            var survey = await new DomainService<Survey>(_repository.SurveyRepository).GetById(request.Id, cancellationToken) ?? throw new SurveyNotFoundException();
            var response = _mapper.Map<SurveyResponse>(survey);
            return response;
        }
    }
}
