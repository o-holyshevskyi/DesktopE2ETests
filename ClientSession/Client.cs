using DriverCore;
using Logger;

namespace ClientSession;

internal class Client : IClient
{
    private readonly ILogger _logger;
    private readonly IWinDriver _winDriver;

    public Client(ILogger logger, IWinDriver winDriver)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _winDriver = winDriver ?? throw new ArgumentNullException(nameof(winDriver));
    }

    public void StartApp()
    {
        _logger.Info("Start Calculator Application");

        _winDriver.RunDriver();
    }
}
