using Domain.Entities;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(a => a.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ExerciseRepository>();
builder.Services.AddScoped<TrainingRepository>();
builder.Services.AddScoped<UserRepository>();

builder.Services.AddCors(options => options.AddPolicy(
                            "Web",
                            policy => policy
                                .AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                        ));

builder.Services.AddAuthentication();

builder.Services.AddAuthorization();

builder.Services.AddAuthentication().AddJwtBearer();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddErrorDescriber<CustomIdentityErrorDescriber>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api" });
    c.MapType<decimal>(() => new OpenApiSchema { Type = "number", Format = "decimal" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JTW Authorization header usando Bearer.
                                        Entre com 'Bearer' [Espaço] entao coloque seu Token.
                                        Exemplo: 'Bearer 123456abcdefg'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header
                            },
                            new List<string>()
                        }
                });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseCors("Web");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapIdentityApi<User>();

app.Run();
