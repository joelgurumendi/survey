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

namespace Surveys.Application.Surveys.Handlers.Questions
{
    internal class CreateQuestionHandler : IRequestHandler<CreateQuestionCommand>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateQuestionHandler(IUnitOfWork repository, IMapper mapper, IMediator mediator)
        {
            _repository = repository;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = _mapper.Map<Question>(request);
            var expression = new FindQuestionByIdOrNameSpecification(question.Id, question.Label).And(new IsNotDeletedSpecification<Question>()).ToExpression();
            var questionFound = await _repository.QuestionRepository.FindByCriteria(expression, cancellationToken);
            if (questionFound != null) throw new QuestionAlreadyExisitsException();
            await _repository.QuestionRepository.Add(question, cancellationToken);
            await _repository.SaveChange(cancellationToken);
            if (request.Options != null)
                foreach (var option in request.Options)
                {
                    var optionCommand = new CreateOptionCommand { QuestionId = question.Id, Label = option.Label, Order = option.Order, CreatedBy = request.CreatedBy, Role = request.Role };
                    await _mediator.Send(optionCommand, cancellationToken);
                }

        }
    }
}
