using OpenQA.Selenium.Appium;

namespace Configurations;

public interface IConfig
{
    AppiumOptions GetConfiguration();
}
