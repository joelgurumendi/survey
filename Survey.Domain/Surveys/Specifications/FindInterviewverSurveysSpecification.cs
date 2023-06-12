using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindInterviewverSurveysSpecification : Specification<Survey>
    {
        private readonly Guid _userId;
        public FindInterviewverSurveysSpecification(Guid userId)
        {
            _userId = userId;
        }
        public override Expression<Func<Survey, bool>> ToExpression()
        {
            return survey => survey.CreatedBy.Equals(_userId);
        }
    }
}
