using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys
{
    public class Answer : Entity
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; init; }
        public Guid QuestionId { get; init; }        
        public Guid? OptionId { get; init; }
        public string? Value { get; init; }
        public Answer(Guid surveyId, Guid versionId, Guid questionId, Guid? optionId, string? value) : base()
        {
            SurveyId = surveyId;
            QuestionId = questionId;
            VersionId = versionId;
            OptionId = optionId;
            Value = value;
        }
        public Answer(Guid surveyId, Guid versionId, Guid questionId, Guid? optionId, Guid createdBy, string? value) : base(createdBy) 
        {
            SurveyId = surveyId;
            Value = value;
            QuestionId = questionId;
            VersionId = versionId;
            OptionId = optionId;
        }

        public virtual Survey Survey { get; set; }
        public virtual Version Version { get; set; }
        public virtual Question Question { get; set; }        
        public virtual Option Option { get; set; }
    }
}
