using OpenQA.Selenium.Appium.Windows;

namespace ClientSession;

public interface IClient
{
    WindowsDriver<WindowsElement> StartApp();
}
