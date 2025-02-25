using LoginMiddlewareExcerciseClassOriented.Middlewares;
using LoginMiddlewareExcerciseClassOriented.Services;

namespace LoginApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IRRDLoginService, RRD_VPNLoginService>();

            var app = builder.Build();
            app.UseMiddleware<RRD_LoginAuthentication_Middleware>();
            app.UseMiddleware<RRD_LoginAutharization_Middleware>();
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();

            // app.MapGet("/", () => "Hello World!");

            app.Run();
        }

    }

}


/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
*/