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
    public class AnswerTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        public AnswerTypeController(IMediator mediator, IHttpContextAccessor context)
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
                var query = new GetAnswersTypeQuery { CreatedBy = _userId, Role = _role};
                var answersType = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<IEnumerable<AnswerTypeResponse>>(answersType);
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
