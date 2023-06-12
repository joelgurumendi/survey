namespace Surveys.Api.Requests.Versions
{
    public class CreateVersionRequest
    {
        public Guid SurveyId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
