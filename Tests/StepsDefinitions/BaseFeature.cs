using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow.Infrastructure;
using TestFramework.Helpers.Logs;
using TestFramework.Sessions;

namespace Tests.StepsDefinitions;

public abstract class BaseFeature
{
    protected readonly WindowsDriver<WindowsElement> driver;

    protected BaseFeature(ISpecFlowOutputHelper outputHelper) 
    {
        Logger.Initialize(outputHelper);
        driver = LiveSession.StartApp();
    }
}
