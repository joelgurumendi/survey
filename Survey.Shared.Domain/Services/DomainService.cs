using Surveys.Shared.Domain.Specifications;

namespace Surveys.Shared.Domain.Services
{
    public class DomainService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;
        public DomainService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetByUserId(Guid userId, CancellationToken cancellationToken)
        {
            var expression = new ByUserIdSpecification<T>(userId).And(new IsNotDeletedSpecification<T>()).ToExpression();
            return await _repository.FindManyByCriteria(expression, cancellationToken);
        }

        public async Task<T?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var expression = new ByIdSpecification<T>(id).And(new IsNotDeletedSpecification<T>()).ToExpression();
            return await _repository.FindByCriteria(expression, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            var expression = new IsNotDeletedSpecification<T>().ToExpression();
            return await _repository.FindManyByCriteria(expression, cancellationToken);
        }
    }
}
