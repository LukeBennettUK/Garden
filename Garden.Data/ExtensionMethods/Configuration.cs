using Microsoft.Extensions.Configuration;
using Garden.Configuration;

namespace Garden.Data.ExtensionMethods;

public static class Configuration
{
    public static IConfigurationBuilder AddDataConfig(this IConfigurationBuilder builder, string environmentName)
    {
        return builder.AddGardenConfig(environmentName, "data");
    }
}