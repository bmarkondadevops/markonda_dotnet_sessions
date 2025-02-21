using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


app.UseMiddleware<AuthenticationMiddleware>();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
