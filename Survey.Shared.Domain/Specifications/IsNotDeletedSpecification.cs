using System.Linq.Expressions;

namespace Surveys.Shared.Domain.Specifications
{
    public class IsNotDeletedSpecification<T> : Specification<T> where T : Entity
    {
        public override Expression<Func<T, bool>> ToExpression()
        {
            return entity => !entity.IsDeleted;
        }
    }
}
