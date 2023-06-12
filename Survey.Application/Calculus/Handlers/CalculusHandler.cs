using Surveys.Application.Calculus.Queries;
using Surveys.Application.Calculus.Responses;
using Surveys.Domain.Surveys;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using Surveys.Shared.Domain.Specifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Calculus.Handlers
{
    internal class CalculusHandler : IRequestHandler<CalculusQuery, CalculusResponse>
    {
        private readonly IUnitOfWork _repository;
        public CalculusHandler(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task<CalculusResponse> Handle(CalculusQuery request, CancellationToken cancellationToken)
        {
            List<Answer> answers = new();
            double total = 0;
            var answersFound = await new DomainService<Answer>(_repository.AnswerRepository).GetAll(cancellationToken);
            var totalParticipant = answersFound.Select(answer => answer.CreatedBy).Distinct().Count();
            foreach (var option in request.Options)
            {
                var expresion = new FindAnswersBySurveyVersionQuestionOptionSpecification(request.SurveyId, request.VersionId, request.QuestionId, option).And(new IsNotDeletedSpecification<Answer>()).ToExpression();
                answers.AddRange(await _repository.AnswerRepository.FindManyByCriteria(expresion, cancellationToken));
            }
            if (request.CalculusOption == (int)CalculusOptions.PERCENTAGE)
            {                
                var answersGrouped = answers.GroupBy(answer => answer.OptionId).Select(g => g.Count());
                var sum = answersGrouped.Sum(answer => answer);                
                var subTotal = (double)sum / (double)totalParticipant;
                total = subTotal * 100;
            }
            if (request.CalculusOption == (int)CalculusOptions.AVERAGE)
            {
                var answersGrouped = answers.GroupBy(answer => answer.OptionId).Select((g, i) => new AverageAnswerGrouped
                {
                    Options = g.Count(),
                    Value = i + 1
                });
                var sum = answersGrouped.Sum(answer => answer.Value * answer.Options);
                total = (double)sum / (double)totalParticipant;
            }
            if (request.CalculusOption == (int)CalculusOptions.MEDIAN)
            {
            }
            if (request.CalculusOption == (int)CalculusOptions.STANDARD_DEVIATION)
            {
            }
            return new CalculusResponse { Total = total};
        }
    }

    class AverageAnswerGrouped
    {
        public int Options { get; set; }
        public int Value { get; set; }
    }
}
