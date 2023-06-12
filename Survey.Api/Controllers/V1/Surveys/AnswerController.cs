using Surveys.Api.Requests.Answers;
using Surveys.Application.Surveys.Commands;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Surveys
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        public AnswerController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpPost]
        public async Task<IActionResult> AnswerSurvey(AnswerSurveyRequest request, CancellationToken cancellationToken) 
        {
            if(_role == RolesName.INTERVIEWER)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            try
            {
                var command = new AnswerSurveyCommand { Answers = request.Answers, CreatedBy = _userId, Role = _role };
                await _mediator.Send(command, cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }            
        }
    }
}
