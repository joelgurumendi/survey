using AutoMapper;
using Surveys.Application.Session.Commands;
using Surveys.Domain.Session;
using Surveys.Domain.Session.Exceptions;
using Surveys.Shared.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surveys.Application.Session.Queries;

namespace Surveys.Application.Session.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<User> _repository;
        private readonly IMediator _mediator;
        public CreateUserHandler(IMapper mapper, IRepository<User> repository, IMediator mediator)
        {
            _mapper = mapper;
            _repository = repository;
            _mediator = mediator;
        }
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            var query = new GetExistingUserByEmailQuery { Email = user.Email };
            try
            {
                var userFound = await _mediator.Send(query, cancellationToken);
                throw new UserAlreadyExistsException();
            }
            catch (UserNotFoundException)
            {
                user.CreatedBy = user.Id;
                await _repository.Add(user, cancellationToken);
                await _repository.SaveChange(cancellationToken);
            }
            
        }
    }
}
