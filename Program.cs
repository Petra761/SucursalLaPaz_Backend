using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sucursal_La_Paz_microservicio.Core.Interfaces;
using Sucursal_La_Paz_microservicio.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);

//railway

var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL")
                       ?? builder.Configuration.GetConnectionString("SucursalLP_Context")
                       ?? throw new InvalidOperationException("Connection string 'SucursalLP_Context' not found.");

builder.Services.AddDbContext<SucursalLP_Context>(options =>
    options.UseNpgsql(connectionString));


// local
//builder.Services.AddDbContext<SucursalLP_Context>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("SucursalLP_Context") ?? throw new InvalidOperationException("Connection string 'SucursalLP_Context' not found.")));

// Scope services

builder.Services.AddScoped<ISolicitudRepository, SolicitudRepository>();

// Cors policy

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SucursalLP_Context>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
