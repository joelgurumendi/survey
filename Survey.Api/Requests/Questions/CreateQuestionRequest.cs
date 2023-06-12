using Surveys.Application.Surveys.Commands;

namespace Surveys.Api.Requests.Questions
{
    public class CreateQuestionRequest
    {
        public Guid AnswerTypeId { get; set; }
        public Guid VersionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public IEnumerable<QuestionOptionCommand>? Options { get; set; }
    }
}
