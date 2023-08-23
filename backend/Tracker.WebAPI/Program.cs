using Microsoft.EntityFrameworkCore;
using Tracker.BLL.Services;
using Tracker.BLL.Services.Fakes;
using Tracker.BLL.Services.Interfaces;
using Tracker.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

if (builder.Environment.IsDevelopment())
{
    builder.Services
        .AddDbContext<TrackerDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DevelopmentConnection")));
}
else
{
    builder.Services.AddEntityFrameworkSqlServer()
        .AddDbContext<TrackerDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnection")));
}

builder.Services.AddSingleton<IBugService, BugService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
