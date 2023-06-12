using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Domain.Surveys;
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
    internal class GetAllQuestionBySurveyHandler : IRequestHandler<GetAllQuestionsBySurveyQuery, IEnumerable<QuestionResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _repository;
        public GetAllQuestionBySurveyHandler(IMapper mapper, IUnitOfWork repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<IEnumerable<QuestionResponse>> Handle(GetAllQuestionsBySurveyQuery request, CancellationToken cancellationToken)
        {
            var expression = new FindQuestionByVersionId(request.VersionId).And(new IsNotDeletedSpecification<Question>()).ToExpression();
            var questions = await _repository.QuestionRepository.FindManyByCriteria(expression, cancellationToken);
            var response = _mapper.Map<List<QuestionResponse>>(questions);
            response.ForEach(question => question.SurveyId = request.SurveyId);
            return response;
        }
    }
}
