using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Responses
{
    public class QuestionResponse
    {
        public Guid Id { get; set; }
        public Guid AnswerTypeId { get; set; }
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public IEnumerable<OptionResponse>? Options { get; set; }
    }
}
