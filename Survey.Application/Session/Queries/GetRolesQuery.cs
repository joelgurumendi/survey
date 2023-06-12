﻿using Surveys.Application.Session.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.Application.Session.Queries
{
    public class GetRolesQuery : IRequest<IEnumerable<RoleResponse>>
    {
    }
}
