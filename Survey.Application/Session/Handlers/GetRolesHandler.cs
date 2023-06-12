using AutoMapper;
using Surveys.Application.Session.Queries;
using Surveys.Application.Session.Responses;
using Surveys.Domain.Session;
using Surveys.Shared.Domain;
using Surveys.Shared.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Session.Handlers
{
    internal class GetRolesHandler : IRequestHandler<GetRolesQuery, IEnumerable<RoleResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Role> _repositorie;
        public GetRolesHandler(IRepository<Role> repositorie, IMapper mapper)
        {
            _repositorie = repositorie;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RoleResponse>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = await new DomainService<Role>(_repositorie).GetAll(cancellationToken);

            return _mapper.Map<IEnumerable<RoleResponse>>(roles);
        }
    }
}
