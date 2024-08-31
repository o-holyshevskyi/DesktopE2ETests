using Configurations;
using DriverCore;
using Logger;
using OpenQA.Selenium.Appium.Windows;

namespace ClientSession;

internal class Client(ILogger logger, IWinDriver winDriver, IConfig config) : IClient
{
    private readonly ILogger _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private readonly IWinDriver _winDriver = winDriver ?? throw new ArgumentNullException(nameof(winDriver));
    private readonly IConfig _config = config ?? throw new ArgumentNullException(nameof(config));
    private WindowsDriver<WindowsElement> _clientSession = null;

    public void StartApp()
    {
        _logger.Info("Start Calculator Application");

        _winDriver.RunDriver();

        if (_clientSession == null)
        {
            var options = _config.GetConfiguration();

            _clientSession = new WindowsDriver<WindowsElement>(new Uri(_winDriver.Url), options);

            Validate();

            _clientSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.2);
        }
    }

    public WindowsElement FindElement(string selector)
    {
        Validate();

        var winElement = _clientSession.FindElementByAccessibilityId(selector);

        return winElement;
    }

    private void Validate()
    {
        if (_clientSession is null)
        {
            ArgumentNullException.ThrowIfNull(_clientSession);
        }
    }
}
