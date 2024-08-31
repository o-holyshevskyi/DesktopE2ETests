using ClientSession;
using OpenQA.Selenium.Appium.Windows;
using PageObjects.Main.Actions;

namespace PageObjects.Main;

internal class Numbers(IClient client) : INumbers
{
    private readonly IClient _client = client ?? throw new ArgumentNullException(nameof(client));

    WindowsElement INumbers.Number_1 => _client.FindElement("num1Button");
    WindowsElement INumbers.Number_2 => _client.FindElement("num2Button");
    WindowsElement INumbers.Number_3 => _client.FindElement("num3Button");
    WindowsElement INumbers.Operation_E => _client.FindElement("equalButton");
    WindowsElement INumbers.Operation_P => _client.FindElement("plusButton");

    INumbersActions INumbers.Actions => new NumbersActions(this);
}
