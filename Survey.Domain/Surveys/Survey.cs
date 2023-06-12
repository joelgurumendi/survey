using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;

namespace Surveys.Domain.Surveys
{
    public partial class Survey : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Survey(string name, string description, Guid createdBy) : base(createdBy)
        {
            Name = name;
            Description = description;
            Versions = new HashSet<Version>();
        }
        public Survey(Guid id, string name, string description, Guid createdBy) : base(id, createdBy)
        {
            Name = name;
            Description = description;
            Versions = new HashSet<Version>();
        }
        public virtual ICollection<Version> Versions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
