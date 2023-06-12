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
    public class OptionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;

        public OptionController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOptionCommand command, CancellationToken cancellationToken)
        {
            try
            {
                command.CreatedBy = _userId;
                command.Role = _role;
                await _mediator.Send(command, cancellationToken);
                var response = new OKResponse();
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);       }
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOptionCommand command, CancellationToken cancellationToken)
        {
            try
            {
                command.CreatedBy = _userId;
                command.Role = _role;
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
            var command = new DeleteOptionCommand { Id = id, CreatedBy = _userId, Role = _role };
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
