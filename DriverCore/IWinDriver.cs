namespace DriverCore;

public interface IWinDriver
{
    string Url { get; }
    void RunDriver();
}
