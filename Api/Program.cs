using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conf = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", false, true)
    .Build();

builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(conf["ConnectionStrings:mydb"]));
builder.Services.AddScoped<DbContext, MyDbContext>();
builder.Services.AddScoped<ICommunityService, CommunityService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();