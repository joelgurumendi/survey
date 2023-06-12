using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Domain.Session;
using Surveys.Domain.Session.Exceptions;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Session.Handlers
{
    internal class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserResponse>
    {
        private readonly IRepository<User> _repository; 
        private readonly IMapper _mapper;
        public GetUserByIdHandler(IRepository<User> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<UserResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var userFound = await new DomainService<User>(_repository).GetById(request.Id, cancellationToken) ?? throw new UserNotFoundException();
            return _mapper.Map<UserResponse>(userFound);
        }
    }
}
