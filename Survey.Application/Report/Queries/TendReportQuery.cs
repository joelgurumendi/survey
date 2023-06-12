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
    public class TendReportQuery : Request, IRequest<AnswerUserResponses>
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
