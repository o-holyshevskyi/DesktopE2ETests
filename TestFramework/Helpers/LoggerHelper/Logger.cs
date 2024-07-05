using TechTalk.SpecFlow.Infrastructure;
using TestFramework.Models.Structure.Enums.Helpers;

namespace TestFramework.Helpers.Logs;

public class Logger
{
    private static Logger _instance;
    private static readonly object _instanceLock = new object();
    private static ISpecFlowOutputHelper _outputHelper;

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }

            return _instance;
        }
    }

    public static void Initialize(ISpecFlowOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    public static void Fatal(string message)
    {
        LogMessage(LoggerSeverity.FATAL, message);
    }

    public static void Error(string message)
    {
        LogMessage(LoggerSeverity.ERROR, message);
    }

    public static void Warning(string message)
    {
        LogMessage(LoggerSeverity.WARNING, message);
    }

    public static void Info(string message)
    {
        LogMessage(LoggerSeverity.INFO, message);
    }

    private static void LogMessage(LoggerSeverity loggerSeverity, string message)
    {
        if (_outputHelper == null)
        {
            throw new InvalidOperationException("Logger is not initialized with ISpecFlowOutputHelper.");
        }

        message = BuildLogMessage(loggerSeverity, message);

        _outputHelper.WriteLine(message);
    }

    private static string BuildLogMessage(LoggerSeverity loggerSeverity, string message)
    {
        string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
        string formattedMessage = $@"
            ------------------------------------------
            Timestamp   : {timestamp}
            Severity    : {loggerSeverity}
            Message     : '{message}'
            ------------------------------------------";

        return formattedMessage;
    }
}
