
var webAppBuilder = WebApplication.CreateBuilder(args);



var webApp = webAppBuilder.Build();//before build register services

//function orieted, class orineted
webApp.MapGet("/", () => {

    Console.WriteLine("http request came ");
    // return "hello world";

    return new { CompanyName= "RRD",Location= "Chennai" };


});//minimal code



webApp.Run();//before teh run register middleware
