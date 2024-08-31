using Logger;
using OpenQA.Selenium.Appium;

namespace Configurations;

internal class SessionConfiguration(ILogger logger) : IConfig
{
    private readonly string calculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
    private readonly ILogger _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    public AppiumOptions GetConfiguration()
    {
        _logger.Info("Config Appium options to run calculator.");

        var appiumOptions = new AppiumOptions();
        appiumOptions.AddAdditionalCapability("app", calculatorAppId);
        appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

        return appiumOptions;
    }
}
