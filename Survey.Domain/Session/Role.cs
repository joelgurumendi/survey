
using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Session
{
    public class Role : Entity
    {
        public string Name { get; init; }
        public bool IsAdmin { get; init; }
        public Role(string name, bool isAdmin, Guid createdBy) : base(createdBy)
        {
            Name = name;
            IsAdmin = isAdmin;
        }
    }
}
