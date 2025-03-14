var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.MapControllerRoute(
     name: "default",
     pattern: "{controller=Customer}/{action=Register}/{id?}"
    );

app.Run();
