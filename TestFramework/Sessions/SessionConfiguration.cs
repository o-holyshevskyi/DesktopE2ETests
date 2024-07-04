using OpenQA.Selenium.Appium;

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
        appiumOptions.AddAdditionalCapability("app", calculatorAppId);
        appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

        return appiumOptions;
    }
}
