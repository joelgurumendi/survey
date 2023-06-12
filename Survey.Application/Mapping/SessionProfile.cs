using AutoMapper;
using Surveys.Application.Session.Commands;
using Surveys.Application.Session.Responses;
using Surveys.Domain.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surveys.Application.Report.Response;

namespace Surveys.Application.Mapping
{
    public class SessionProfile : Profile
    {
        public SessionProfile()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<User, UserResponse>();
            CreateMap<UserResponse, UserReportResponse>();
            CreateMap<Role, RoleResponse>();
        }
    }
}
