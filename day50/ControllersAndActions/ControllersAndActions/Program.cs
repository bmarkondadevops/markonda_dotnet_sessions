var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();



app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Customer}/{action=Index}/{myid?}"
    
 );

app.Run();


//void Foo(string firstname,string lastName,string location="") { 

//}

//Foo(lastName: "hello lastname", firstname: "my lastName");