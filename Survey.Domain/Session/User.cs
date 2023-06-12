using Surveys.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Session
{
    public class User : Entity
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public User(string name, string email) : base()
        {
            Name = name;
            Email = email;
        }
        public User(string name, string email, Guid createdBy) : base(createdBy)
        {
            Name = name;
            Email = email;
        }
        public User(Guid id, string name, string email, Guid createdBy) : base(id, createdBy)
        {
            Name = name;
            Email = email;
        }
    }
}
