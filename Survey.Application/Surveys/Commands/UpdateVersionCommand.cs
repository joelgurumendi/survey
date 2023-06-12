using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Commands
{
    public class UpdateVersionCommand : Request, IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime To { get; set; }
    }
}
