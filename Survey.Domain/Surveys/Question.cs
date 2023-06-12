using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;

namespace Surveys.Domain.Surveys
{
    public partial class Question : Entity
    {
        public Guid AnswerTypeId { get; set; }
        public Guid VersionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public Question(Guid answerTypeId, Guid versionId,  string label, int order, bool required, Guid createdBy) : base(createdBy)
        {
            AnswerTypeId = answerTypeId;
            VersionId = versionId;
            Label = label;
            Order = order;
            Required = required;
            Options = new HashSet<Option>();
            Answers = new HashSet<Answer>();
        }
        public Question(Guid id, Guid answerTypeId, Guid versionId, string label, int order, bool required, Guid createdBy) : base(id, createdBy)
        {
            AnswerTypeId = answerTypeId;
            VersionId = versionId;
            Label = label;
            Order = order;
            Required = required;
            Options = new HashSet<Option>();
            Answers = new HashSet<Answer>();
        }

        public virtual AnswerType AnswerType { get; set; } = null!;
        public virtual Version Version { get; set; } = null!;
        public virtual ICollection<Option>? Options { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
