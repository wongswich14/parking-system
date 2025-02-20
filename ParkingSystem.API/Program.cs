
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ParkingSystemDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<VehicleService>();





var app = builder.Build();


//if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors(config =>
{
    config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", builder =>
//        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//});


//app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();
