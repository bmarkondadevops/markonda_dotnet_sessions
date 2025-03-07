using BankApplicationV2.Models;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();

// Registering SQL Server DB Connection Provider
builder.Services.AddSingleton<IDbConnectionProvider>(provider =>
{
    return new SqlServerDbConnectionProvider(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registering SQL-based Employee Service
builder.Services.AddSingleton<ICustomerService, CustomerSqlService>();

var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Customer}/{action=DisplayAll}/{id?}");


app.Run();
