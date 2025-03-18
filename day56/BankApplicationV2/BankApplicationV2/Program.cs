using System;
using BankApplicationV2.Models;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1); // You can adjust this as needed.
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//builder.Services.AddSession();
//builder.Services.AddSingleton<IEmployeeService, EmployeeInMemoryService>();

// Registering SQL Server DB Connection Provider
builder.Services.AddSingleton<IDbConnectionProvider>(provider =>
{
    return new SqlServerDbConnectionProvider(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registering SQL-based Employee Service
builder.Services.AddSingleton<ICustomerService, CustomerSqlService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Customer}/{action=Index}/{id?}");


app.Run();
