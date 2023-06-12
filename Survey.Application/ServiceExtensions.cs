using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Surveys.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplications(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}