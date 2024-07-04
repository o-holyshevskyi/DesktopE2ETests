using OpenQA.Selenium.Appium.Windows;

namespace TestFramework.Client;

public class LS
{
    private readonly WindowsDriver<WindowsElement> driver;

    public readonly WindowsElement zeroNumber;
    public readonly WindowsElement oneNumber;
    public readonly WindowsElement plusNumber;
    public readonly WindowsElement equalNumber;

    public readonly WindowsElement resultTextBox;

    public LS(WindowsDriver<WindowsElement> driver)
    {
        this.driver = driver;

        zeroNumber = this.driver.FindElementByAccessibilityId("num0Button");
        oneNumber = this.driver.FindElementByAccessibilityId("num1Button");
        plusNumber = this.driver.FindElementByAccessibilityId("plusButton");
        equalNumber = this.driver.FindElementByAccessibilityId("equalButton");

        resultTextBox = this.driver.FindElementByAccessibilityId("CalculatorResults");
    }
}
