using OpenQA.Selenium.Appium.Windows;

namespace Selectors;

public interface ISelectorService
{
    WindowsElement GetElement(string selector);
}
