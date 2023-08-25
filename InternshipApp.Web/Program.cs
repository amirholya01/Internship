using Internship.Datalayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<InternshipAppContext>(options =>
{
    options.UseMySql(connectionString, serverVersion: ServerVersion.AutoDetect(connectionString));
});
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();