using Microsoft.EntityFrameworkCore;
using Spg.CifBazar.Application;
using Spg.CifBazar.Application.Services;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.Infrastructure;
using Spg.CifBazar.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context
string connectionString = builder.Configuration.GetConnectionString("SqLite")!;
builder.Services.AddDbContext<CifBazarContext>(options => options.UseSqlite(connectionString));

// Add Services
builder.Services.AddTransient<IReadOnlyShopService, ShopService>();
builder.Services.AddTransient<IWritableShopService, ShopService>();
builder.Services.AddTransient<IReadOnlyProductService, ProductService>();
builder.Services.AddTransient<IWritableProductService, ProductService>();

builder.Services.AddTransient<IReadOnlyShopRepository, ShopRepository>();
builder.Services.AddTransient<IWritableShopRepository, ShopRepository>();
builder.Services.AddTransient<IReadOnlyProductRepository, ProductRepository>();
builder.Services.AddTransient<IWritableProductRepository, ProductRepository>();
builder.Services.AddTransient<IReadOnlyCategoryRepository, CategoryRepository>();

builder.Services.AddTransient<IDateTimeService, DateTimeService>();
builder.Services.AddTransient<IProductNumberService, ProductNumberService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
