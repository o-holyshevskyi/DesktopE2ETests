using OpenQA.Selenium.Appium;
using TestFramework.Helpers.Logs;

namespace TestFramework.Sessions;

internal class SessionConfiguration
{
    private readonly string calculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
    private readonly AppiumOptions appiumOptions;

    public SessionConfiguration()
    {
        appiumOptions = new AppiumOptions();
    }

    public AppiumOptions ConfigOptions()
    {
        Logger.Info("Config Appium options to run calculator.");

        appiumOptions.AddAdditionalCapability("app", calculatorAppId);
        appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

        return appiumOptions;
    }
}
