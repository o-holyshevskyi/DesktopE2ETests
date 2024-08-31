using OpenQA.Selenium.Appium.Windows;
using PageObjects.Main.Actions;

namespace PageObjects.Main;

public interface INumbers
{
    internal WindowsElement Number_1 { get; }
    internal WindowsElement Number_2 { get; }
    internal WindowsElement Number_3 { get; }
    internal WindowsElement Operation_E { get; }
    internal WindowsElement Operation_P { get; }
    INumbersActions Actions { get; }
}
