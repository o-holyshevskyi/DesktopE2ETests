using OpenQA.Selenium.Appium.Windows;
using PageObjects.Main.Actions;
using Selectors;

namespace PageObjects.Main;

internal class Numbers(ISelectorService selectorService) : INumbers
{
    private readonly ISelectorService _selectorService = selectorService ?? throw new ArgumentNullException(nameof(selectorService));

    WindowsElement INumbers.Number_1 => _selectorService.GetElement("num1Button");
    WindowsElement INumbers.Number_2 => _selectorService.GetElement("num2Button");
    WindowsElement INumbers.Number_3 => _selectorService.GetElement("num3Button");
    WindowsElement INumbers.Operation_E => _selectorService.GetElement("equalButton");
    WindowsElement INumbers.Operation_P => _selectorService.GetElement("plusButton");

    INumbersActions INumbers.Actions => new NumbersActions(this);
}
