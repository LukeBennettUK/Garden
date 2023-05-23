using Garden.Configuration;
using Garden.Data;
using Garden.Data.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder();

builder.Configuration
    .SetBasePath(AppContext.BaseDirectory)
    .AddApplicationConfig(builder.Environment.EnvironmentName)
    .AddLocalConfig(builder.Environment.EnvironmentName)
    .AddDataConfig(builder.Environment.EnvironmentName);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Api documentation and exploration service, similar would be: OpenAPI, API Blueprint, RAML
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GardenDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins, policyBuilder =>
    {
        policyBuilder.WithOrigins(builder.Configuration["ApplicationSettings:WebUrl"])
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
    
