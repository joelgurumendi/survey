using AutoMapper;
using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Domain.Session;
using Surveys.Domain.Session.Exceptions;
using Surveys.Domain.Session.Specifications;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Specifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Session.Handlers
{
    internal class GetExistingUserByEmailHandler : IRequestHandler<GetExistingUserByEmailQuery, UserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<User> _repository;
        public GetExistingUserByEmailHandler(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<UserResponse> Handle(GetExistingUserByEmailQuery request, CancellationToken cancellationToken)
        {
            _ = new MailAddress(request.Email);
            var expression = new FindUserLogedByEmailSpecification(request.Email).And(new IsNotDeletedSpecification<User>()).ToExpression();
            var userFound = await _repository.FindByCriteria(expression, cancellationToken) ?? throw new UserNotFoundException();
            return _mapper.Map<UserResponse>(userFound);
        }
    }
}
