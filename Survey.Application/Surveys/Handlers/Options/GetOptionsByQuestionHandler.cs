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

namespace Surveys.Application.Surveys.Handlers.Options
{
    internal class GetOptionsByQuestionHandler : IRequestHandler<GetOptionsByQuestionQuery, IEnumerable<OptionResponse>>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        public GetOptionsByQuestionHandler(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<OptionResponse>> Handle(GetOptionsByQuestionQuery request, CancellationToken cancellationToken)
        {
            var options = new DomainService<Option>(_repository.OptionRepository).GetAll(cancellationToken);
            return _mapper.Map<IEnumerable<OptionResponse>>(options);
        }
    }
}
