using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindQuestionByVersionId : Specification<Question>
    {
        private readonly Guid _versionId;
        public FindQuestionByVersionId(Guid versionId)
        {
            _versionId = versionId;
        }
        public override Expression<Func<Question, bool>> ToExpression()
        {
            return question => question.VersionId == _versionId;
        }
    }
}
