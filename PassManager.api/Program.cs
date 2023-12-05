using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PassManager.Business;
using PassManager.Data;
using PassManager.Domain.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace PassManager.api;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
        {
            options.InvalidModelStateResponseFactory = context => new BadRequestObjectResult(context.ModelState)
            {
                ContentTypes =
                {
                    Application.Json,
                    Application.Xml
                }
            };
        }).AddXmlSerializerFormatters();

        builder.InitServices();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(o => o.AddPolicy("myAllowSpecificOrigins", builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }));

        var app = builder.Build();
        app.UseCors("myAllowSpecificOrigins");
        app.InitDb();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}

internal static class Extentions
{
    internal static WebApplicationBuilder InitServices(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddScoped<IUserService, UserService>()
            .AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            })
            .AddCors(o => o.AddPolicy("myAllowSpecificOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

        return builder;
    }

    internal static void InitDb(this WebApplication app)
    {
        using IServiceScope scope = app.Services.CreateScope();
        using DataContext context = scope.ServiceProvider.GetRequiredService<DataContext>();
        context.Database.Migrate();
    }
}
