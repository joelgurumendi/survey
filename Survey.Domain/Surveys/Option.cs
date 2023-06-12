using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;

namespace Surveys.Domain.Surveys
{
    public class Option : Entity
    {
        public Guid QuestionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public Option(Guid questionId, string label, int order, Guid createdBy) : base(createdBy)
        {
            QuestionId = questionId;
            Label = label;
            Order = order;
            Answers = new HashSet<Answer>();
        }
        public Option(Guid id, Guid questionId, string label, int order, Guid createdBy) : base(id, createdBy)
        {
            QuestionId = questionId;
            Label = label;
            Order = order;
            Answers = new HashSet<Answer>();
        }
        public virtual Question Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

    }
}
