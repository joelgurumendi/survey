using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;

namespace Surveys.Domain.Surveys
{
    public partial class AnswerType : Entity
    {
        public string Name { get; init; }
        public AnswerType(string name, Guid createdBy) : base(createdBy)
        {
            Name = name;
            Questions = new HashSet<Question>();
        }
        public AnswerType(Guid id, string name, Guid createdBy) : base(id, createdBy)
        {
            Name = name;
            Questions = new HashSet<Question>();
        }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
