using EcommerceAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            var connection = builder.Configuration.GetConnectionString("ConnectionDb");

            // Add services to the container.
            builder.Services.AddDbContext<EcommerceContext>(options => 
            options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
}
