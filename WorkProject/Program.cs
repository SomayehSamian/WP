using Microsoft.EntityFrameworkCore;
using WorkProject.ActionFilter;
using WorkProject.Infrastructure.Context;
using WorkProject.Infrastructure.Implimentation;
using WorkProject.Respositories.Interface;
using WorkProject.Services.Implimantation;
using WorkProject.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<ApplicationDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myConn")));
builder.Services.AddDbContext<ApplicationDbContext>(item => item.UseSqlServer("Server=.;Database=WorkProjectDb;Trusted_Connection=True,TrustServerCertificate=True"));

//builder.Services.AddScoped(typeof(ICustomeRepository), typeof(CustomRepository));
//builder.Services.AddTransient<ICustomService, CustomService>();

builder.Services.AddScoped<ICustomeRepository, CustomRepository>();
builder.Services.AddScoped<ICustomService, CustomService>();

builder.Services.AddSingleton<MyLogFilter>();

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
