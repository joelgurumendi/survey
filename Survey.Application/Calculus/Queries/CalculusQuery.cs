using Surveys.Application.Calculus.Responses;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Calculus.Queries
{
    public class CalculusQuery : Request, IRequest<CalculusResponse>
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
        public Guid QuestionId { get; set; }
        public int CalculusOption { get; set; }
        public IEnumerable<Guid> Options { get; set; }
    }
}
