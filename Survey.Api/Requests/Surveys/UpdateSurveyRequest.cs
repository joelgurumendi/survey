using Surveys.Application.Surveys.Commands;

namespace Surveys.Api.Requests.Surveys
{
    public class UpdateSurveyRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string VersionName { get; set; }
        public string Description { get; set; }
        public IEnumerable<SurveyQuestionCommand> Questions { get; set; }
    }
}
