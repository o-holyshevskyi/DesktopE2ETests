using Logger;
using System.Diagnostics;

namespace DriverCore;

internal class WinDriver(ILogger logger) : IWinDriver
{
    private readonly ILogger _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private Process winAppDriverProcess = null;

    public string Url { get { return "http://127.0.0.1:4723"; } }

    public void RunDriver()
    {
        if (!LookForWinAppDriver("WinAppDriver", false))
            RunWithAppDriver();
    }

    private bool LookForWinAppDriver(string processName, bool killProcess)
    {
        _logger.Info("Check if WinAppDriver is run.");

        bool found = false;

        foreach (var process in Process.GetProcessesByName(processName))
        {
            winAppDriverProcess = process;
            found = true;
        }

        if (found && killProcess)
        {
            winAppDriverProcess.Kill();
        }

        return found;
    }

    private Process RunWithAppDriver()
    {
        _logger.Info("Start WinAppDriver.");

        string command = @"cd " + "C:\\Program Files (x86)\\Windows Application Driver" + "&&WinAppDriver.exe";

        var startAppInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/K" + command,
            WindowStyle = ProcessWindowStyle.Normal,
            CreateNoWindow = true,
            UseShellExecute = true,
        };

        return Process.Start(startAppInfo);
    }
}
