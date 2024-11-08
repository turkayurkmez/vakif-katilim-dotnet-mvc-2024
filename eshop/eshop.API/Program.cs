using eshop.Common;
using eshop.Common.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(option => option.AddPolicy("allow", builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
    /*
     * https://www.vakifkatilim.com.tr/
     * http://www.vakifkatilim.com.tr/
     * https://hesap.vakifkatilim.com.tr/
     * https://www.vakifkatilim.com.tr:8034/
     */
}));
var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddApplicationServices(connectionString);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters()
                    {
                         ValidateIssuer = true,
                         ValidateAudience = true,
                         ValidIssuer= "vakifkatilim.server",
                         ValidAudience = "vakifkatilim.client",
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Burası 256 bitlik özel ifade haberiniz olsun")),
                        
                    };
                });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("allow");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
