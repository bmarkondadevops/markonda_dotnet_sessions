using EmployeeCRUDApp.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.Cookie.Name = "myrrdformcookie";
                    options.LoginPath = "/Login/Index";

                });


builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();
var app = builder.Build();



app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Employee}/{action=DisplayAll}/{id?}");


app.Run();
