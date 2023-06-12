namespace Surveys.Api.Requests.Questions
{
    public class UpdateQuestionRequest
    {
        public Guid Id { get; set; }
        public Guid AnswerTypeId { get; set; }
        public Guid VersionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
    }
}
