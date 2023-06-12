using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Exceptions;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Shared.Domain.Specifications;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Handlers.Options
{
    public class CreateOptionHandler : IRequestHandler<CreateOptionCommand>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        public CreateOptionHandler(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Handle(CreateOptionCommand request, CancellationToken cancellationToken)
        {
            var option = _mapper.Map<Option>(request);
            var expresion = new FindOptionByIdOrNameSpecification(option.Id, option.Label).And(new IsNotDeletedSpecification<Option>()).ToExpression();
            var optionFound = await _repository.OptionRepository.FindByCriteria(expresion, cancellationToken);
            if (optionFound != null) throw new OptionAlreadyExistsException();
            await _repository.OptionRepository.Add(option, cancellationToken);
            await _repository.SaveChange(cancellationToken);
        }
    }
}
