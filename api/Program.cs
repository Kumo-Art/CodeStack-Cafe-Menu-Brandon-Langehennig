using System.Security.Authentication.ExtendedProtection;
using api.Data;
using api.Repository;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

 builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DatabaseConnection")));

//  builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
//  builder.Services.AddScoped<ICategoriesServices, CategoriesServices>();
 
//  builder.Services.AddScoped<IItemsRepository, ItemsRepository>();
//  builder.Services.AddScoped<IItemsServices, ItemsServices>();

//  builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
//  builder.Services.AddScoped<IRestaurantServices, RestaurantServices>();

 builder.Services.AddCors(Options =>
 {
     Options.AddPolicy("Frontend", PolicyEnforcement =>
     {
           PolicyEnforcement.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod();
     });
 });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("Frontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
