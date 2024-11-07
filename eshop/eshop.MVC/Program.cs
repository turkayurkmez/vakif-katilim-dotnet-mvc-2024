using eshop.Application;
using eshop.Common.Extensions;
using eshop.Infrastructure;
using eshop.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IProductService, CustomProductService>();
//builder.Services.AddScoped<ICategoryService, CustomCategoryService>();
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddScoped<IProductRepository, ProductRepostiory>();
//builder.Services.AddScoped<IUserService, UserService>();

var connectionString = builder.Configuration.GetConnectionString("db");
//builder.Services.AddDbContext<VakifEshopDbContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddApplicationServices(connectionString);




builder.Services.AddSession(opt => opt.IdleTimeout = TimeSpan.FromMinutes(5));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option => {
                    option.LoginPath = "/Users/Login";
                    option.ReturnUrlParameter = "gidilecekUrl";
                    option.AccessDeniedPath = "/Users/AccessDenied";

                });

builder.Services.AddOutputCache(option =>
{
    option.DefaultExpirationTimeSpan = TimeSpan.FromMinutes(5);
});

builder.Services.AddResponseCaching();

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
app.UseOutputCache();
app.UseResponseCaching();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "category",
    pattern: "Category/{categoryId?}/Page{pageNo}",
    defaults: new { controller = "Home", action = "Index", pageNo=1 }
    );

app.MapControllerRoute(
    name: "pagination",
    pattern: "Page{pageNo}",
    defaults: new { controller = "Home", action = "Index",pageNo=1 }
    );



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
