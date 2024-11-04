var builder = WebApplication.CreateBuilder(args);
//uygulamanizda olmasini istediginiz her yapiyi konfigüre edip tanimlayabilirsiniz.
//Bu uygulama MVC mimarisini kullanır:
builder.Services.AddControllersWithViews();


var app = builder.Build();


var message = builder.Configuration.GetValue<string>("Message");
app.Logger.LogInformation($"Host mesajı: {message}");

app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");


app.Run();
