using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Day55Assignment.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Day55AssignmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Day55AssignmentContext") ?? throw new InvalidOperationException("Connection string 'Day55AssignmentContext' not found.")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Company}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
