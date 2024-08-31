using GlobalSetup;
using PageObjects;
using Utils.DI;

namespace E2ETests;

public class Tests
{
    private IForm _form;

    [SetUp]
    public void Setup()
    {
        GlobalTestSetup.SetupDependencies();
        GlobalTestSetup.RunClient();

        _form = ServiceLocator.GetService<IForm>();
    }

    [Test]
    public void Test1()
    {
        int firstNumber = 1;
        int secondNumber = 3;

        _form.Numbers.Actions.ClickNumber(firstNumber)
            .ClickOperation("+")
            .ClickNumber(secondNumber)
            .ClickOperation("=");

        var result = _form.Result.Actions.GetResult();
        var intResult = int.Parse(result.ToString());

        Assert.That(intResult, Is.EqualTo(firstNumber + secondNumber));
    }
}