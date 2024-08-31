using ClientSession;
using OpenQA.Selenium.Appium.Windows;
using PageObjects.ResultField.Actions;

namespace PageObjects.ResultField;

internal class Result(IClient client) : IResult
{
    private readonly IClient _client = client ?? throw new ArgumentNullException(nameof(client));

    WindowsElement IResult.ResultTextField => _client.FindElement("CalculatorResults");

    IResultActions IResult.Actions => new ResultActions(this);
}
