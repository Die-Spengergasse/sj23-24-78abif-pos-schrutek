using Microsoft.EntityFrameworkCore;
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
builder.Services.AddTransient<IReadOnlyShopRepository, ShopRepository>();

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
