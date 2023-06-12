using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindAwnsersByVersionIdSpecification : Specification<Answer>
    {
        private readonly Guid _surveyId;
        private readonly Guid _versionId;
        public FindAwnsersByVersionIdSpecification(Guid surveyId, Guid versionId)
        {
            _surveyId = surveyId;
            _versionId = versionId;
        }
        public override Expression<Func<Answer, bool>> ToExpression()
        {
            return answer => answer.SurveyId.Equals(_surveyId) && answer.VersionId.Equals(_versionId);
        }
    }
}
