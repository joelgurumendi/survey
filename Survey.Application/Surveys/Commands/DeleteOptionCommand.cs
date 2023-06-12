using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Commands
{
    public class DeleteOptionCommand : Request, IRequest
    {
        public Guid Id { get; set; }
    }
}
