using LoginMiddleWareApp.services;

var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

builder.Services.AddControllersWithViews();
var app = builder.Build();
// Add logging middleware
app.UseMiddleware<LoggingMiddleware>();

//app.MapGet("/", () => "Hello World!");

// Other configurations...

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
