using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<HrDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Auth}/{action=Login}");

app.MapControllerRoute(name: "superadmin", pattern: "superadmin/dashboard", defaults: new { controller = "SuperAdmin", action = "Dashboard" });
app.MapControllerRoute(name: "admin", pattern: "admin/dashboard", defaults: new { controller = "Admin", action = "Dashboard" });
app.MapControllerRoute(name: "manager", pattern: "manager/dashboard", defaults: new { controller = "Manager", action = "Dashboard" });
app.MapControllerRoute(name: "employee", pattern: "employee/dashboard", defaults: new { controller = "Employee", action = "Dashboard" });
app.Run();
