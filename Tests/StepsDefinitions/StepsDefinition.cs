using FluentAssertions;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using TestFramework.Client;
using TestFramework.Sessions;

namespace Tests.StepsDefinitions;

[Binding]
public class StepsDefinition
{
    LS LS = null;
    private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
    
    protected static WindowsDriver<WindowsElement> driver = null;

    public StepsDefinition(ISpecFlowOutputHelper outputHelper)
    {
        _specFlowOutputHelper = outputHelper;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        driver = LiveSession.StartApp();
        _specFlowOutputHelper.WriteLine("WinAppDriverProcess started");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        LiveSession.StopApp();
        _specFlowOutputHelper.WriteLine("\nCalculator closed");
    }

    [Given("Calculator starts")]
    public void CalculatorStarts() 
    {
        LS = new LS(driver);
    }

    [When("User selects number (.*)")]
    public void SelectNumber(int number)
    {
        if (number == 0)
        {
            LS.zeroNumber.Click();
        }
        else if (number == 1)
        {
            LS.oneNumber.Click();
        }
    }

    [When("User press operator (.*)")]
    public void SelectOperator(string symbolOperator)
    {
        if (symbolOperator == "+") 
        {
            LS.plusNumber.Click();
        }
        else if (symbolOperator == "=")
        {
            LS.equalNumber.Click();
        }
    }

    [Then("Result should be (.*)")]
    public void ValidateResult(double result)
    {
        var temp = LS.resultTextBox.GetAttribute("Name");
        temp = temp.Replace("Display is ", "").Trim();

        result.Should().Be(double.Parse(temp));
    }
}
