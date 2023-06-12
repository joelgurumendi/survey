using Surveys.Api.Requests.Calculus;
using Surveys.Shared.Domain.Responses;
using Surveys.Shared.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Surveys.Application.Calculus.Queries;
using Surveys.Application.Calculus.Responses;

namespace Surveys.Api.Controllers.V1.Calculus
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CalculusController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        public CalculusController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CalculusRequest request, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                return Unauthorized(new UnAuthorizationResponse());
            }
            var query = new CalculusQuery { SurveyId = request.SurveyId, VersionId = request.VersionId, QuestionId = request.QuestionId, CalculusOption = request.CalculusOption, Options = request.Options, CreatedBy = _userId, Role =_role };
            var calculus = await _mediator.Send(query, cancellationToken);
            var response = new OKResponse<CalculusResponse>(calculus);
            return Ok(response);
        }
    }
}
