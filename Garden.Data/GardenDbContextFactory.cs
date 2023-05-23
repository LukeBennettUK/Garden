using Garden.Data.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Garden.Data;

public class GardenDbContextFactory : IDesignTimeDbContextFactory<GardenDbContext>
{
    public GardenDbContext CreateDbContext(string[] args)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddDataConfig(environment)
            .Build();
        
        var optionsBuilder = new DbContextOptionsBuilder<GardenDbContext>();

        optionsBuilder.UseSqlServer(config.GetConnectionString("default"));

        return new GardenDbContext(optionsBuilder.Options);
    }
}