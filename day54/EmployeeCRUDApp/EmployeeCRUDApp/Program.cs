using EmployeeCRUDApp.Models;
using EmployeeCRUDApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();

// Registering SQL Server DB Connection Provider
builder.Services.AddSingleton<IDbConnectionProvider>(provider =>
{
    return new SqlServerDbConnectionProvider(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registering SQL-based Employee Service
builder.Services.AddSingleton<IEmployeeService, EmployeeSqlService>();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Employee}/{action=DisplayAll}/{id?}");


app.Run();
