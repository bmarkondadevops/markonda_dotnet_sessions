using DIWebApplication.Middleware;
using DIWebApplication.services;

var builder = WebApplication.CreateBuilder(args);
//DI container
builder.Services.AddControllersWithViews();
//builder.Services.AddSingleton<IRRDEmailService, TwilioEmailService>(); //singleton
builder.Services.AddTransient<IRRDEmailService, TwilioEmailService>();


var app = builder.Build();//abover build register sevices

//app.MapGet("/", () => "Hello World!");


app.UseMiddleware<RddLogAndEmailingMiddleWare>();
app.MapDefaultControllerRoute();
//{controller}/{action} , /Customer/GetDetails
// {controller=home}/{action=Index}

app.Run();//above run register middleware
