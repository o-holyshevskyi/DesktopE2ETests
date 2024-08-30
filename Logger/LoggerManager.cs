namespace Logger;

internal class LoggerManager : ILogger
{
    public void Info(string message)
    {
        Console.WriteLine(message);
    }
}
