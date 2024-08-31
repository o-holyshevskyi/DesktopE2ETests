using ClientSession;
using OpenQA.Selenium.Appium.Windows;

namespace Selectors;

internal class SelectorService(IClient client) : ISelectorService
{
    private readonly IClient _client = client ?? throw new ArgumentNullException(nameof(client));
    public WindowsElement GetElement(string selector)
    {
        return _client.FindElement(selector);
    }
}
