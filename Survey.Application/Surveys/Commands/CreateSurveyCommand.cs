using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Commands
{
    public class CreateSurveyCommand : Request, IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<SurveyQuestionCommand> Questions { get; set; }
    }

    public class SurveyQuestionCommand
    {
        public Guid AnswerTypeId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public IEnumerable<QuestionOptionCommand>? Options { get; set; }
    }
}
