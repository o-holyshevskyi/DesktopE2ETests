namespace PageObjects.ResultField.Actions;

public class ResultActions(IResult result) : IResultActions
{
    private readonly IResult _result = result ?? throw new ArgumentNullException(nameof(result));

    public string GetResult()
    {
        var result = _result.ResultTextField.Text;
        
        return result.Replace("Display is ", string.Empty);
    }
}
