namespace PageObjects.Main.Actions;

internal class NumbersActions(INumbers numbers) : INumbersActions
{
    private readonly INumbers _numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));

    public INumbersActions ClickNumber(int number)
    {
        switch (number)
        {
            case 1:
                _numbers.Number_1.Click();
                break;
            case 2:
                _numbers.Number_2.Click();
                break;
            case 3:
                _numbers.Number_3.Click();
                break;
        }

        return this;
    }

    public INumbersActions ClickOperation(string operation)
    {
        switch (operation)
        {
            case "+":
                _numbers.Operation_P.Click();
                break;
            case "=":
                _numbers.Operation_E.Click();
                break;
        }

        return this;
    }
}
