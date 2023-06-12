using Surveys.Application.Report.Queries;
using Surveys.Application.Report.Response;
using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Application.Surveys.Queries;
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
using System.Xml.Linq;

namespace Surveys.Application.Report.Handlers
{
    internal class DetailReportHandler : IRequestHandler<DetailReportQuery, DetailReportResponse>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public DetailReportHandler(IUnitOfWork repository, IMediator mediator, IMapper mapper)
        {
            _repository = repository;
            _mediator = mediator;
            _mapper = mapper;
        }
        public async Task<DetailReportResponse> Handle(DetailReportQuery request, CancellationToken cancellationToken)
        {
            var questionsQuery = new GetAllQuestionsBySurveyQuery { SurveyId = request.SurveyId, VersionId = request.VersionId };
            var questionsFound = await _mediator.Send(questionsQuery, cancellationToken);
            var expression = new FindAwnsersByVersionIdSpecification(request.SurveyId, request.VersionId).And( new IsNotDeletedSpecification<Answer>()).ToExpression();
            var answersFound = await _repository.AnswerRepository.FindManyByCriteria(expression, cancellationToken);
            var usersId = answersFound.GroupBy(answer => answer.CreatedBy).Select(x => x.Key);
            var users = new List<UserReportResponse>();
            foreach (var userId in usersId)
            {
                var userQuery = new GetUserByIdQuery { Id = userId };
                var userFound = await _mediator.Send(userQuery);
                users.Add(_mapper.Map<UserReportResponse>(userFound));
            }
            var questionsAnswers = questionsFound.Select(question => new QuestionAnswerResponse
            {
                Id = question.Id,
                AnswerTypeId = question.AnswerTypeId,
                Label = question.Label,
                Order = question.Order,
                Required = question.Required,
                Answers = answersFound.Where(answer => answer.QuestionId == question.Id).Select(answer =>
                new AnswerUserResponse {
                    Id = answer.Id,
                    QuestionId = answer.QuestionId,
                    Value = answer.Option != null ? answer.Option.Label : answer.Value,
                    User = users.Single(user => user.Id == answer.CreatedBy)
                })
            });
            return new DetailReportResponse { Questions = questionsAnswers };
        }
    }
}


