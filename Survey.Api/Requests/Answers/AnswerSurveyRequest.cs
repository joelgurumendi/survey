using Surveys.Application.Surveys.Commands;

namespace Surveys.Api.Requests.Answers
{
    public class AnswerSurveyRequest
    {
        public IEnumerable<AnswerCommand> Answers { get; set; }
    }
}
