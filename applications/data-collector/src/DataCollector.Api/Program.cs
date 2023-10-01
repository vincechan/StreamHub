using DataCollector.Api;
using DataCollector.Core;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://localhost:8080");
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<ITVShowRepository, TVShowRepository>();
builder.Services.AddScoped<ITmdbClient, TmdbClient>();
builder.Services.AddScoped<IDataCollectorService, DataCollectorService>();

// builder.Configuration.AddEnvironmentVariables(prefix: "STREAMHUB_");
builder.Configuration.AddEnvironmentVariables();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
