var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapDefaultControllerRoute();
//app.MapControllerRoute(name: "default",
//    pattern: "{controller=Customer}/{action=Index}/{myid?}"

// );
app.Run();
