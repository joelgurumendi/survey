using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindVersionBySurveyIdAndNameSpecification : Specification<Version>
    {
        private readonly Guid _surveyId;
        private readonly string _name;
        public FindVersionBySurveyIdAndNameSpecification(Guid surveyId, string name)
        {
            _surveyId = surveyId;
            _name = name;
        }
        public override Expression<Func<Version, bool>> ToExpression()
        {
            return version => version.Id.Equals(_surveyId) && version.Name.Equals(_name); 
        }
    }
}
