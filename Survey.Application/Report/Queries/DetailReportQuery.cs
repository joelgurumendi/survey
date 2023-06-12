using Surveys.Application.Report.Response;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Report.Queries
{
    public class DetailReportQuery : Request, IRequest<DetailReportResponse>
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
    }
}
