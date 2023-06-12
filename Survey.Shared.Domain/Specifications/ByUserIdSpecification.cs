using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Shared.Domain.Specifications
{
    public class ByUserIdSpecification<T> : Specification<T> where T : Entity
    {
        private readonly Guid _userId;
        public ByUserIdSpecification(Guid userId)
        {
            _userId = userId;
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            return entity => entity.CreatedBy.Equals(_userId);
        }
    }
}
