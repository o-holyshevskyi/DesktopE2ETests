using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using TestFramework.Helpers;
using TestFramework.Helpers.Logs;

namespace TestFramework.Sessions;

internal class WADriver
{
    private static Process winAppDriverProcess = null;

    protected static WindowsDriver<WindowsElement> session = null;

    public WADriver() { }

    public void Start()
    {
        if (!LookForWinAppDriver("WinAppDriver", false))
            winAppDriverProcess = RunWithAppDriver();
    }

    public static bool LookForWinAppDriver(string processName, bool killProcess)
    {
        Logger.Info("Check if WinAppDriver is run.");

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

    private static Process RunWithAppDriver()
    {
        Logger.Info("Start WinAppDriver.");

        var configuration = ConfigurationReader.GetAppSetting();
        string command = @"cd " + configuration.WinAppDriverApp + "&&WinAppDriver.exe";

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
