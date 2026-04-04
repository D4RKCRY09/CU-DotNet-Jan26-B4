using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VagaBond.TravelAPI.Data;
using VagaBond.TravelAPI.Repository;
using VagaBond.TravelAPI.Services;

namespace VagaBondTravelAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<VagaBondTravelAPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("VagaBondTravelAPIContext") ?? throw new InvalidOperationException("Connection string 'VagaBondTravelAPIContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
            builder.Services.AddScoped<IDestinationServices, DestinationServices>();

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
