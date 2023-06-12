using Surveys.Application.Surveys.Responses;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Surveys.Queries
{
    public class GetAllSurveyQuery: Request, IRequest<IEnumerable<SurveyVersionResponse>>
    {
    }
}
