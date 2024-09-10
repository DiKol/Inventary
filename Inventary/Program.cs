using Microsoft.Extensions.Configuration;
using Mbr.Inventary.Infrastructure.Database;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("allowAll", policy =>
            {
                policy.AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowAnyOrigin();
            });
        });

       
        builder.Services.AddDatabase("host=127.0.0.1;port=5432;database=inventory;userid=postgres;password=12345678;timeout=10;");

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(x => x
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());


        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}