var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(name: "default", pattern: "", defaults: new { controller = "Auth", action = "Login" });
app.MapControllerRoute(name: "forget-password", pattern: "forget-password", defaults: new { controller = "Auth", action = "ForgetPassword" });
app.MapControllerRoute(name: "login-check", pattern: "login-check", defaults: new { controller = "Auth", action = "LoginCheck" });

app.Run();
