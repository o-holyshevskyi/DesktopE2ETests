using OpenQA.Selenium.Appium.Windows;
using PageObjects.ResultField.Actions;

namespace PageObjects.ResultField;

public interface IResult
{
    internal WindowsElement ResultTextField { get; }
    IResultActions Actions { get; }
}
