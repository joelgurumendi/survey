using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Commands
{
    public class AnswerSurveyCommand : Request , IRequest
    {
        public IEnumerable<AnswerCommand> Answers { get; set; }
    }

    public class AnswerCommand
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid? OptionId { get; set; }
        public string? Value { get; set; }
    }
}
