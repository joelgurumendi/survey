using System.Linq.Expressions;

namespace Surveys.Shared.Domain.Specifications
{
    public class AndSpecification<T> : Specification<T> where T : Entity 
    { 
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            ParameterExpression param = leftExpression.Parameters[0];

            BinaryExpression andExpression;

            if (ReferenceEquals(param, rightExpression.Parameters[0]))
            {
                andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);
            }
            else
            {
                andExpression = Expression.AndAlso(leftExpression.Body, Expression.Invoke(rightExpression, param));
            }

            return Expression.Lambda<Func<T, bool>>(andExpression, param);
        }
    }
}
