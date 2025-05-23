using Microsoft.EntityFrameworkCore;
using Northwind.Demo.Business.IServices;
using Northwind.Demo.Business.Services;
using Northwind.Demo.Common.Profiles;
using Northwind.Demo.Repository.Database;
using Northwind.Demo.Repository.IRepositories;
using Northwind.Demo.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string connectionString = builder.Configuration["DbContext:ConnectionString"] ??
           throw new InvalidOperationException("Database connection string not found!");


builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseNpgsql(connectionString);
    //.EnableSensitiveDataLogging() // 打印实际参数值
    //.LogTo(Console.WriteLine);   // 打印到控制台
});

builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
builder.Services.AddScoped<ICustomersService, CustomersService>();


builder.Services.AddAutoMapper(typeof(CustomerProfile).Assembly);

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
