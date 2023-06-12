using Surveys.Api.Requests.Questions;
using Surveys.Application.Surveys.Commands;
using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Domain.Surveys;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Surveys
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        public QuestionController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpGet("{surveyId}/{versionId}")]
        public async Task<IActionResult> Get(Guid surveyId, Guid versionId, CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetAllQuestionsBySurveyQuery { SurveyId = surveyId, VersionId = versionId, CreatedBy = _userId, Role = _role };
                var questions = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<IEnumerable<QuestionResponse>>(questions);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new CreateQuestionCommand { AnswerTypeId = request.AnswerTypeId, CreatedBy = _userId, Role = _role, Label = request.Label, Options = request.Options, Order = request.Order, Required = request.Required, VersionId = request.VersionId };
                await _mediator.Send(command, cancellationToken);
                var response = new OKResponse();
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateQuestionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new UpdateQuestionCommand { AnswerTypeId = request.AnswerTypeId, CreatedBy = _userId, Role = _role, Label = request.Label,  Order = request.Order, Required = request.Required, VersionId = request.VersionId };
                await _mediator.Send(command, cancellationToken);
                var response = new OKResponse();
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            var command = new DeleteQuestionCommand { Id = id, CreatedBy = _userId, Role = _role };
            try
            {
                await _mediator.Send(command, cancellationToken);
                var response = new OKResponse();
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }
        }
    }
}
