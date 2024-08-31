using OpenQA.Selenium.Appium.Windows;
using PageObjects.ResultField.Actions;
using Selectors;

namespace PageObjects.ResultField;

internal class Result(ISelectorService selectorService) : IResult
{
    private readonly ISelectorService _selectorService = selectorService ?? throw new ArgumentNullException(nameof(selectorService));

    WindowsElement IResult.ResultTextField => _selectorService.GetElement("CalculatorResults");

    IResultActions IResult.Actions => new ResultActions(this);
}
