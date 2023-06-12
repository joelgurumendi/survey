using Surveys.Application.Surveys.Commands;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Handlers.Answers
{
    public class AnswerSurveyHandler : IRequestHandler<AnswerSurveyCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;
        public AnswerSurveyHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task Handle(AnswerSurveyCommand request, CancellationToken cancellationToken)
        {
            var answers = _mapper.Map<List<Answer>>(request.Answers);
            answers.ForEach(answer => answer.CreatedBy = request.CreatedBy);
            await _repository.AnswerRepository.AddRange(answers, cancellationToken);
            await _repository.SaveChange(cancellationToken);
        }
    }
}
