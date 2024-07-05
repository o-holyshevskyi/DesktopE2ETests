using OpenQA.Selenium.Appium.Windows;
using TestFramework.Helpers.Logs;

namespace TestFramework.Client;

public class CalculatorClient
{
    private readonly WindowsDriver<WindowsElement> driver;

    private readonly WindowsElement zeroNumber;
    private readonly WindowsElement oneNumber;
    private readonly WindowsElement twoNumber;
    private readonly WindowsElement threeNumber;
    private readonly WindowsElement fourNumber;
    private readonly WindowsElement fiveNumber;
    private readonly WindowsElement sixNumber;
    private readonly WindowsElement sevenNumber;
    private readonly WindowsElement eightNumber;
    private readonly WindowsElement nineNumber;

    private readonly WindowsElement plusNumber;
    private readonly WindowsElement minusNumber;
    private readonly WindowsElement equalNumber;

    private readonly WindowsElement resultTextBox;

    public CalculatorClient(WindowsDriver<WindowsElement> driver)
    {
        this.driver = driver;

        zeroNumber = this.driver.FindElementByAccessibilityId("num0Button");
        oneNumber = this.driver.FindElementByAccessibilityId("num1Button");
        twoNumber = this.driver.FindElementByAccessibilityId("num2Button");
        threeNumber = this.driver.FindElementByAccessibilityId("num3Button");
        fourNumber = this.driver.FindElementByAccessibilityId("num4Button");
        fiveNumber = this.driver.FindElementByAccessibilityId("num5Button");
        sixNumber = this.driver.FindElementByAccessibilityId("num6Button");
        sevenNumber = this.driver.FindElementByAccessibilityId("num7Button");
        eightNumber = this.driver.FindElementByAccessibilityId("num8Button");
        nineNumber = this.driver.FindElementByAccessibilityId("num9Button");

        plusNumber = this.driver.FindElementByAccessibilityId("plusButton");
        minusNumber = this.driver.FindElementByAccessibilityId("minusButton");
        equalNumber = this.driver.FindElementByAccessibilityId("equalButton");

        resultTextBox = this.driver.FindElementByAccessibilityId("CalculatorResults");
    }

    public void ClickNumberButton(int number)
    {
        Logger.Info($"Trying click {number}.");

        switch (number)
        {
            case 0:
                zeroNumber.Click();
                break;
            case 1:
                oneNumber.Click();
                break;
            case 2:
                twoNumber.Click();
                break;
            case 3:
                threeNumber.Click();
                break;
            case 4:
                fourNumber.Click();
                break;
            case 5:
                fiveNumber.Click();
                break;
            case 6:
                sixNumber.Click();
                break;
            case 7:
                sevenNumber.Click();
                break;
            case 8:
                eightNumber.Click();
                break;
            case 9:
                nineNumber.Click();
                break;
            default:
                var message = $"Operation {number} is invalid for clicking. Value can be between 0 and 9.";
                Logger.Fatal(message);
            throw new ArgumentOutOfRangeException(message);
        }

        Logger.Info($"The {number} is clicked.");
    }

    public void ClickOperationButton(char operation)
    {
        Logger.Info($"Trying click {operation}.");

        switch (operation)
        {
            case '+':
                plusNumber.Click();
                break;
            case '-':
                minusNumber.Click();
                break;
            case '=':
                equalNumber.Click();
                break;
            default:
                var message = $"Operation {operation} is invalid for clicking.";
                Logger.Fatal(message);
                throw new ArgumentOutOfRangeException(message);
        }

        Logger.Info($"The {operation} is clicked.");
    }

    public double GetResult()
    {
        Logger.Info($"Trying get result of the operation from the result text box.");

        var result = resultTextBox.GetAttribute("Name");
        result = result.Replace("Display is ", "").Trim();

        Logger.Info($"Result is {result}");

        return double.Parse(result);
    }
}
