using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Session.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
