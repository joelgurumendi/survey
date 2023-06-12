using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class RangeSpecification : Specification<Answer>
    {
        private readonly DateTime from;
        private readonly DateTime to;
        public RangeSpecification(DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
        }
        public override Expression<Func<Answer, bool>> ToExpression()
        {
            return answer => answer.CreatedAt >= from &&  answer.CreatedAt <= to;
        }
    }
}
