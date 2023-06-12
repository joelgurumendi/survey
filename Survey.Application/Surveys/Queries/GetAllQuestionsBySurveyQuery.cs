using Surveys.Application.Surveys.Responses;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Queries
{
    public class GetAllQuestionsBySurveyQuery : Request, IRequest<IEnumerable<QuestionResponse>>
    {
        public Guid SurveyId { get; set; }
        public Guid VersionId { get; set; }
    }
}
