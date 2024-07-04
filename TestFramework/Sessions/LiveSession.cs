using OpenQA.Selenium.Appium.Windows;

namespace TestFramework.Sessions;

public class LiveSession
{
    private const string windowsApplicationDriverUrl = "http://127.0.0.1:4723";

    private static readonly SessionConfiguration sessionConfig = new();
    private static readonly WADriver waDriver = new(); 

    protected static WindowsDriver<WindowsElement> session = null;

    public static WindowsDriver<WindowsElement> StartApp()
    {
        waDriver.Start();

        if (session == null)
        {
            var options = sessionConfig.ConfigOptions();

            session = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUrl), options);

            Validate();

            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.2);
        }

        return session;
    }

    public static void StopApp()
    {
        session?.CloseApp();
        session?.Dispose();
        session = null;
        //WADriver.LookForWinAppDriver("WinAppDriver", true);
    }

    private static void Validate()
    {
        if (session is null)
        {
            ArgumentNullException.ThrowIfNull(session);
        }
    }
}
