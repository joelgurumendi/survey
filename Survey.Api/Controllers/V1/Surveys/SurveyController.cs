using Surveys.Api.Requests.Surveys;
using Surveys.Application.Surveys.Commands;
using Surveys.Application.Surveys.Queries;
using Surveys.Application.Surveys.Responses;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Surveys
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        
        public SurveyController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetAllSurveyQuery { CreatedBy = _userId, Role = _role};
                var surveys = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<IEnumerable<SurveyVersionResponse>>(surveys);
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSurveyRequest request, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            var command = new CreateSurveyCommand {Name = request.Name, Description = request.Description, CreatedBy = _userId, Role = _role, Questions = request.Questions };
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

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSurveyRequest request, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            var command = new UpdateSurveyCommand { Id = request.Id, VersionName = request.VersionName, Name = request.Name, Description = request.Description, CreatedBy = _userId, Role = _role, Questions = request.Questions };
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            var command = new DeleteSurveyCommand { Id = id, CreatedBy = _userId, Role = _role};
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
