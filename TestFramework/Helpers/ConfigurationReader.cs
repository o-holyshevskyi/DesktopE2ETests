using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace TestFramework.Helpers;

internal static class ConfigurationReader
{
    private static IConfigurationRoot _configuration;

    static ConfigurationReader()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
        
        _configuration = builder.Build();
    }

    public static AppSettings GetAppSetting()
    {
        var appSettings = new AppSettings();
        _configuration.GetSection("AppSettings").Bind(appSettings);
        Validator.ValidateObject(appSettings, new ValidationContext(appSettings), validateAllProperties: true);

        return appSettings;
    }
}

internal class AppSettings
{
    [Required]
    public string WinAppDriverApp { get; set; }
}
