using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Persistence;
using cityScope.NET.Server.Persistence.DummyData;
using cityScope.NET.Server.Persistence.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("CityScopeConnectionString")));
builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
builder.Services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();


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
