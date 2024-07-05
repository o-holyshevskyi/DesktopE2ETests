using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using TestFramework.Client;
using TestFramework.Helpers.Logs;
using TestFramework.Sessions;

namespace Tests.StepsDefinitions;

[Binding]
public class Calculator_Feature(ISpecFlowOutputHelper outputHelper) : BaseFeature(outputHelper)
{
    CalculatorClient CalculatorClient = null;

    [AfterScenario]
    public void AfterScenario()
    {
        LiveSession.StopApp();
        Logger.Info("Calculator closed");
    }

    [Given("Calculator starts")]
    public void CalculatorStarts() 
    {
        CalculatorClient = new CalculatorClient(driver);
    }

    [When("User selects number (.*)")]
    public void SelectNumber(int number)
    {
        CalculatorClient.ClickNumberButton(number);
    }

    [When("User press operator (.*)")]
    public void SelectOperator(string symbolOperator)
    {
        char operation = char.Parse(symbolOperator);
        CalculatorClient.ClickOperationButton(operation);
    }

    [Then("Result should be (.*)")]
    public void ValidateResult(double expectedResult)
    {
        var result = CalculatorClient.GetResult();

        result.Should().Be(expectedResult);
    }
}
