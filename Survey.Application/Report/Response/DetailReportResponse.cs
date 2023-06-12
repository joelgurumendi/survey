using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Report.Response
{
    public class DetailReportResponse
    {
        public IEnumerable<QuestionAnswerResponse> Questions { get; set; }
    }

    public class QuestionAnswerResponse
    {
        public Guid Id { get; set; }
        public Guid AnswerTypeId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public IEnumerable<AnswerUserResponse> Answers { get; set; }
    }

    public class UserAnswerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public AnswerResponse Answer { get; set; }
    }

    public class AnswerResponse 
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid UserId { get; set; }
        public string Value { get; set; }
        
    }

    public class AnswerUserResponse
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Value { get; set; }
        public UserReportResponse User { get; set; }
    }

    public record UserReportResponse(Guid Id, string Name, string Email );
}
