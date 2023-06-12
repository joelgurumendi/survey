using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Session
{
    [Route("api/v1/session/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetRolesQuery();
                var roles = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<IEnumerable<RoleResponse>>(roles);
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
