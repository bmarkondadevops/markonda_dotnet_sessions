using Microsoft.EntityFrameworkCore;
using MVCRepositoryApp.Data;
using MVCRepositoryApp.Repository;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = DecryptConnectionString( builder.Configuration.GetConnectionString("mydbserver"));

builder.Services.AddDbContext<NITRKLDbContext>(options => {
    options.UseSqlServer(connectionString);
});
builder.Services.AddScoped<IOrganizationRepository, OrganizationEFRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

 string DecryptConnectionString(string encryptedConnectionString)
{
    var encryptedBytes = Convert.FromBase64String(encryptedConnectionString);
    var decryptedBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.LocalMachine);
    return Encoding.UTF8.GetString(decryptedBytes);
}
