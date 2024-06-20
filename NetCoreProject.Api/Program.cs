using NetCoreProject.DAL.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataAccessLayer(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();
