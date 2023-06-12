using Surveys.Application.Session.Commands;
using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Domain.Session.Exceptions;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Session
{
    [Route("api/v1/session/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetExistingUSer([FromQuery] string email, CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetExistingUserByEmailQuery { Email = email };
                var user = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<UserResponse>(user);
                return Ok(response);
            }
            catch (FormatException ex)
            {
                var response = new BadRequestResponse(ex.Message);
                return BadRequest(response);
            }
            catch (UserNotFoundException ex)
            {
                var response = new NotFoundResponse(ex.Message);
                return NotFound(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command, CancellationToken cancellation)
        {
            try
            {
                await _mediator.Send(command, cancellation);
                return Ok();
            }
            catch (UserAlreadyExistsException ex)
            {
                var response = new ConflictResponse(ex.Message);
                return Conflict(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }
        }
    }
}
