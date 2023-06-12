using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Responses
{
    public class SurveyVersionCreatedResponse
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
    }
}
