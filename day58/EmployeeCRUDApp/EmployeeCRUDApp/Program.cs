using EmployeeCRUDApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();
var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Employee}/{action=DisplayAll}/{id?}");


app.Run();
