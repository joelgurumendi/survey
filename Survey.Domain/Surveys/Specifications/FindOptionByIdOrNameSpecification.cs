using Surveys.Shared.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Domain.Surveys.Specifications
{
    public class FindOptionByIdOrNameSpecification : Specification<Option>
    {
        private readonly Guid _id;
        private readonly string _name;
        public FindOptionByIdOrNameSpecification(Guid id, string name)
        {
            _id = id;
            _name = name;
        }
        public override Expression<Func<Option, bool>> ToExpression()
        {
            return option => option.Id.Equals(_id) || option.Label.Equals(_name);
        }
    }
}
