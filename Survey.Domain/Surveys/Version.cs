using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;

namespace Surveys.Domain.Surveys
{
    public partial class Version : Entity
    {
        public Guid SurveyId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Version(string name, Guid surveyId, DateTime from, DateTime to, Guid createdBy) : base(createdBy)
        {
            Name = name;
            SurveyId = surveyId;
            From = from;
            To = to;
            Answers = new HashSet<Answer>();
            Questions = new HashSet<Question>();
        }

        public Version(Guid id, string name, Guid surveyId, DateTime from, DateTime to, Guid createdBy) : base(id, createdBy)
        {
            Name = name;
            SurveyId = surveyId;
            From = from;
            To = to;
            Answers = new HashSet<Answer>();
            Questions = new HashSet<Question>();
        }

        public virtual Survey Survey { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
