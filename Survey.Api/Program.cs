using Surveys.Application;
using Surveys.Domain.Session;
using Surveys.Shared.Domain;
using Surveys.Infrastructure.Data;
using Surveys.Domain.Surveys;
using Surveys.Infrastructure.Data.Repsitories;
using Surveys.Infrastructure.Data.Repositories;
using Version = Surveys.Domain.Surveys.Version;
using Surveys.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplications();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSqlServer<SurveyContext>(builder.Configuration.GetConnectionString("local"), options => options.EnableRetryOnFailure());
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IRepository<User>, Repository<User>>();
builder.Services.AddTransient<IRepository<Role>, Repository<Role>>();
builder.Services.AddTransient<AuthorizationMiddleware>();
builder.Services.AddAuthentication().AddGoogle(options =>
    {
        var googleConfig = builder.Configuration.GetSection("GoogleAuth");
        options.ClientId = googleConfig.GetValue<string>("ClientId");
        options.ClientSecret = googleConfig.GetValue<string>("ClientSecret");
    }
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(
            builder => {
                builder.AllowAnyOrigin()
                .AllowAnyHeader().AllowAnyMethod();
            }
        );
}
);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();
app.UseAuthorizationMiddleware();
app.MapControllers();

app.Run();