using eshop.Application;
using eshop.Infrastructure;
using eshop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductService, CustomProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductRepository, ProductRepostiory>();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<VakifEshopDbContext>(option => option.UseSqlServer(connectionString));



builder.Services.AddSession(opt => opt.IdleTimeout = TimeSpan.FromMinutes(5));

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
