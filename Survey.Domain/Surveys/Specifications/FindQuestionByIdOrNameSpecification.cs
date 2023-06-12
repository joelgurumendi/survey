using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindQuestionByIdOrNameSpecification : Specification<Question>
    {
        private readonly Guid _id;
        private readonly string _name;
        public FindQuestionByIdOrNameSpecification(Guid id, string name)
        {
            _id = id;
            _name = name;
        }
        public override Expression<Func<Question, bool>> ToExpression()
        {
            return question => question.Id.Equals(_id) || question.Label.Equals(_name);
        }
    }
}
