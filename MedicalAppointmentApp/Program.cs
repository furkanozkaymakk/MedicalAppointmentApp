using DataAccessLayer.Context;
using DataAccessLayer.Extensions;
using EntityLayer.Entities;
using MedicalAppointmentApp.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using ServiceLayer.Extensions;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

// Razor sayfa yenileme için
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSession();


builder.Services.LoadDataAccessLayerExtension(builder.Configuration); //AddScope
builder.Services.LoadServiceLayerExtension(builder.Configuration); //AddScope


builder.Services.AddDbContext<AddDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AddDbContext>()
    .AddErrorDescriber<CustomIdentityValidator>()
    .AddEntityFrameworkStores<AddDbContext>(); // ýdentity yapýlandýrmasýný aktif etmek


builder.Services.ConfigureApplicationCookie(config => //Cookie Bazlý Ýþlemler
{
    config.LoginPath = new PathString("");
    config.LogoutPath = new PathString("");
    config.Cookie = new CookieBuilder
    {
        Name = "MedicalAppointmentApp",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest // canlýya çýkartacaðýmýz zaman Always
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(1);
    config.AccessDeniedPath = new PathString(""); // Yetkisiz Giriþler
});




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
app.UseSession();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute( //DefaultMapCont.
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();