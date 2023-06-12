using Surveys.Application.Report.Queries;
using Surveys.Application.Report.Response;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Surveys.Api.Controllers.V1.Report
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Guid _userId;
        private readonly string _role;
        public ReportController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            var request = context.HttpContext?.Request;
            _userId = Guid.Parse(request.Headers["profile-user"].ToString());
            _role = request.Headers["profile-role"].ToString();
        }

        [HttpGet("Detail/{surveyId}/{versionId}")]
        public async Task<IActionResult> Detail(Guid surveyId, Guid versionId, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            try
            {
                var query = new DetailReportQuery { SurveyId = surveyId, VersionId = versionId, CreatedBy = _userId, Role = _role };
                var report = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<DetailReportResponse>(report);
                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ServerErrorResponse(ex.Message);
                return StatusCode(500, response);
            }
            
        }

        [HttpGet("Trend/{surveyId}/{versionId}/{from}/{to}")]
        public async Task<IActionResult> Trend(Guid surveyId, Guid versionId,DateTime from, DateTime to, CancellationToken cancellationToken)
        {
            if (_role == RolesName.PARTICIPANT)
            {
                var response = new UnAuthorizationResponse();
                return Unauthorized(response);
            }
            try
            {
                var query = new TendReportQuery { SurveyId = surveyId, VersionId = versionId,From = from,To = to, CreatedBy = _userId, Role = _role };
                var report = await _mediator.Send(query, cancellationToken);
                var response = new OKResponse<AnswerUserResponses>(report);
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
