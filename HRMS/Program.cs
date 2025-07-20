using HRMS.Data;
using Microsoft.EntityFrameworkCore;
using HRMS.Models; // Your models and seeder
using HRMS.SeedData; // (Create this namespace for the seeder class)

// Setup
var builder = WebApplication.CreateBuilder(args);

// Register EF Core with MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

// Add MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();
    DbSeeder.SeedBranches(dbContext);
}

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapDefaultControllerRoute();

app.Run();
