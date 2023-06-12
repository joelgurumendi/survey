using Surveys.Application.Surveys.Commands;
using Surveys.Application.Surveys.Queries;
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
using Version = Surveys.Domain.Surveys.Version;

namespace Surveys.Application.Surveys.Handlers.Surveys
{
    internal class CreateSurveyHandler : IRequestHandler<CreateSurveyCommand>
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateSurveyHandler(IUnitOfWork repository, IMapper mapper, IMediator mediator)
        {
            _repository = repository;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task Handle(CreateSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey = _mapper.Map<Survey>(request);
            try
            {
                var surveyQuery = new GetSurveyByIdQuery { Id = survey.Id };
                var response = await _mediator.Send(surveyQuery, cancellationToken);
                throw new SurveyAlreadyExistsException();
            }
            catch (SurveyNotFoundException)
            {
                await _repository.SurveyRepository.Add(survey, cancellationToken);                
                var version = new Version("Default", survey.Id, DateTime.UtcNow, DateTime.UtcNow.AddDays(10), request.CreatedBy);
                var versionExpresion = new FindVersionBySurveyIdAndNameSpecification(version.Id, version.Name).And(new IsNotDeletedSpecification<Version>()).ToExpression();
                var versionFound = await _repository.VersionRepository.FindByCriteria(versionExpresion, cancellationToken);
                if (versionFound != null) throw new VersionAlreadyExistsException();
                await _repository.VersionRepository.Add(version, cancellationToken);
                foreach (var q in request.Questions)
                {
                    var question = new Question(q.AnswerTypeId, version.Id, q.Label, q.Order, q.Required, request.CreatedBy);
                    await _repository.QuestionRepository.Add(question, cancellationToken);
                    if (q.Options != null)
                        foreach (var opt in q.Options)
                        {
                            var option = new Option(question.Id, opt.Label, opt.Order, request.CreatedBy);
                            await _repository.OptionRepository.Add(option, cancellationToken);
                        }
                }
            }
            await _repository.SaveChange(cancellationToken);
            _repository.Dispose();
        }
    }
}
