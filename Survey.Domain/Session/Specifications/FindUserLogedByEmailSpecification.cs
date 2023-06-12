using Surveys.Shared.Domain.Specifications;
using System.Linq.Expressions;

namespace Surveys.Domain.Session.Specifications
{
    public class FindUserLogedByEmailSpecification : Specification<User>
    {
        private readonly string _email;
        public FindUserLogedByEmailSpecification(string email)
        {
            _email = email;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {

            return user => user.Email == _email;
        }
    }
}
