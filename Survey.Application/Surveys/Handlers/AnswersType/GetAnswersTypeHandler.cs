using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Handlers.AnswersType
{
    internal class GetAnswersTypeHandler : IRequestHandler<GetAnswersTypeQuery, IEnumerable<AnswerTypeResponse>>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        public GetAnswersTypeHandler(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AnswerTypeResponse>> Handle(GetAnswersTypeQuery request, CancellationToken cancellationToken)
        {
            var answersFound = await new DomainService<AnswerType>(_repository.AnswerTypeRepository).GetAll(cancellationToken);
            return _mapper.Map<IEnumerable<AnswerTypeResponse>>(answersFound);
        }
    }
}
