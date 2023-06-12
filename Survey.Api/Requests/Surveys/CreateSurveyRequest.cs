using Surveys.Application.Surveys.Commands;

namespace Surveys.Api.Requests.Surveys
{
    public class CreateSurveyRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<SurveyQuestionCommand> Questions { get; set; }
    }
}
