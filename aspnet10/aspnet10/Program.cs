using aspnet10.Configurations;
using aspnet10.Repositories;
using aspnet10.Services;
using aspnet10.Services.Impl;
using RestWithASPNET10Erudio.Repositories.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.AddSerilogLogging();

builder.Services.AddControllers();

builder.Services.AddDatabaseConfiguration(builder.Configuration);

builder.Services.AddScoped<IPersonService, PersonServicesImpl>();
builder.Services.AddScoped<IBookService, BookServiceImpl>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
