using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Responses
{
    public class OptionResponse
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
    }
}
