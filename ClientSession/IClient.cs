using OpenQA.Selenium.Appium.Windows;

namespace ClientSession;

public interface IClient
{
    void StartApp();
    WindowsElement FindElement(string selector);
}
