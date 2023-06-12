using System.Linq.Expressions;

namespace Surveys.Shared.Domain.Specifications
{
    public class ByIdSpecification<T> : Specification<T> where T : Entity
    {
        private readonly Guid _id;
        public ByIdSpecification(Guid id)
        {
            _id = id;
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            return entity => Equals(entity.Id, _id);
        }
    }
}
