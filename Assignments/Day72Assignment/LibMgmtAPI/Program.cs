
using Serilog;

namespace LibMgmtAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information() // Log Info, Warning, and Error
    .WriteTo.Console()          // Also show logs in the debug console
    .WriteTo.File("logs/myapp-.txt", rollingInterval: RollingInterval.Day) // Save to file
    .CreateLogger();

            builder.Services.AddSerilog();

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

            app.UseSerilogRequestLogging(); 

            app.Run();
        }
    }
}
