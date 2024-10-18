using Domain.Core;
using Mapster;
using MapsterMapper;
using System.Reflection;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddDomain();

builder.Services.AddApplication();

builder.Services.AddMapster();

builder.Services.AddPersistence(builder.Configuration);

builder.Services.AddScoped<IMapper, Mapper>();

builder.Services.AddSingleton(
    TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}




app.UseHttpsRedirection();

app.MapControllers();

app.Run();
