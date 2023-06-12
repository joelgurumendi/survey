namespace Surveys.Api.Requests.Versions
{
    public class UpdateVersionRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime To { get; set; }
    }
}
