namespace Surveys.Api.Requests.Calculus
{
    public class CalculusRequest
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
        public Guid QuestionId { get; set; }
        public int CalculusOption { get; set; }
        public IEnumerable<Guid> Options { get; set; }
    }
}
