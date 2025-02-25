using ServicesAndDIApp.Middlewares;
using ServicesAndDIApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IRRDBlobService, AWSS3BucketBlobService>();

var app = builder.Build();

app.UseRrdAuditionMiddleWare();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
