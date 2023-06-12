using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Commands
{
    public class UpdateQuestionCommand : Request, IRequest
    {
        public Guid Id { get; set; }
        public Guid AnswerTypeId { get; set; }
        public Guid VersionId { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
    }
}
