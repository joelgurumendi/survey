using Surveys.Application.Report.Queries;
using Surveys.Application.Report.Response;
using Surveys.Application.Session.Queries;
using Surveys.Application.Surveys.Queries;
using Surveys.Domain.Surveys.Specifications;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain.Specifications;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Surveys.Application.Report.Handlers
{
    internal class TendReportHandler : IRequestHandler<TendReportQuery, AnswerUserResponses>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public TendReportHandler(IUnitOfWork repository, IMediator mediator, IMapper mapper)
        {
            _repository = repository;
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<AnswerUserResponses> Handle(TendReportQuery request, CancellationToken cancellationToken)
        {
            var questionsQuery = new GetAllQuestionsBySurveyQuery { SurveyId = request.SurveyId, VersionId = request.VersionId };
            var questionsFound = await _mediator.Send(questionsQuery, cancellationToken);
            var expression = new FindAwnsersByVersionIdSpecification(request.SurveyId, request.VersionId).And(new IsNotDeletedSpecification<Answer>()).And(new RangeSpecification(request.From,request.To)).ToExpression();
            var answersFound = await _repository.AnswerRepository.FindManyByCriteria(expression, cancellationToken);
            var usersId = answersFound.GroupBy(answer => answer.CreatedBy).Select(x => x.Key);
            var users = new List<UserReportResponse>();
            foreach (var userId in usersId)
            {
                var userQuery = new GetUserByIdQuery { Id = userId };
                var userFound = await _mediator.Send(userQuery);
                users.Add(_mapper.Map<UserReportResponse>(userFound));
            }

            var daysForAnswer = answersFound.GroupBy(answer => answer.CreatedAt.ToString("yyyy-MM-dd")).Select(x => x.Key).ToList();
            AnswerUserResponses answerUserResponses = new AnswerUserResponses();
            foreach (var days in daysForAnswer)
            {
                AnswerUserResponsesDay answerUserResponsesDay  = new AnswerUserResponsesDay();  
                DateTime targetDate = DateTime.ParseExact(days, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                var filteredAnswers = answersFound.Where(answer => answer.CreatedAt.Date == targetDate.Date).ToList();

                var questionsAnswersss = filteredAnswers.GroupBy(question => question.QuestionId).Select(x => x.Key).ToList();

                

                foreach (var ques in questionsAnswersss)
                {
                    AnswerUserResponsesQuestion answerUserResponsesQuestion = new AnswerUserResponsesQuestion();    
                    var answerByQuestionDay = filteredAnswers.Where(answer => answer.QuestionId == ques).ToList();
                    answerUserResponsesDay.SurveySum = filteredAnswers.Count();
                    answerUserResponsesQuestion.QuestionId = ques;
                    answerUserResponsesQuestion.Order = answerByQuestionDay.FirstOrDefault()?.Question?.Order ?? 0;
                    answerUserResponsesDay.Dia = days;
                    var questionsOPtionDay = answerByQuestionDay.GroupBy(option => option.OptionId).Select(x => x.Key).ToList();
                    foreach (var quesOp in questionsOPtionDay)
                    {
                        var optionDay = answerByQuestionDay.Where(op => op.OptionId == quesOp).ToList();
                        AnswerOption AnswerOption = new AnswerOption();
                        AnswerOption.Option = answerByQuestionDay.FirstOrDefault(x=> x.OptionId == quesOp)?.Option != null ? 
                                              answerByQuestionDay.FirstOrDefault(x => x.OptionId == quesOp)?.Option.Label : 
                                              answerByQuestionDay.FirstOrDefault(x => x.OptionId == quesOp)?.Value;
                        AnswerOption.Value = optionDay.Count();
                        answerUserResponsesQuestion.ListOption.Add(AnswerOption);
                    }
                    answerUserResponsesDay.ListQuestion.Add(answerUserResponsesQuestion);

                }
                answerUserResponses.AnswerUserResponsesDay.Add(answerUserResponsesDay);
            }

            return answerUserResponses;
        }
    }
}
