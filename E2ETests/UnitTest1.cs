using ClientSession;
using GlobalSetup;
using Utils.DI;

namespace E2ETests;

public class Tests
{
    private IClient _client;

    [SetUp]
    public void Setup()
    {
        GlobalTestSetup.SetupDependencies();
        _client = ServiceLocator.GetService<IClient>();
    }

    [Test]
    public void Test1()
    {
        _client.StartApp();
        Assert.Pass();
    }
}