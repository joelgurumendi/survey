using Surveys.Shared.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Surveys.Api.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthorizationMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var path = context.Request.Path.Value;
            if (!path.Contains("session"))
            {
                var profileUser = context.Request.Headers["profile-user"].ToString();
                var profileRole = context.Request.Headers["profile-role"].ToString();
                var isNullOrEmpty = String.IsNullOrEmpty(profileUser) || String.IsNullOrEmpty(profileRole);
                var isDifferentRolesName = profileRole != RolesName.PARTICIPANT && profileRole != RolesName.INTERVIEWER;
                if (isNullOrEmpty || isDifferentRolesName)
                {
                    context.Response.StatusCode = 401;
                    await context.Response.CompleteAsync();
                    return;
                }
            }
                

            await next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthorizationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorizationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationMiddleware>();
        }
    }
}
