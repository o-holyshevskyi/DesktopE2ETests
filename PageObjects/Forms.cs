using ClientSession;
using PageObjects.Main;
using PageObjects.ResultField;

namespace PageObjects;

internal class Forms(IClient client) : IForm
{
    private IClient _client = client ?? throw new ArgumentNullException(nameof(client));

    public INumbers Numbers => new Numbers(_client);
    public IResult Result => new Result(_client);
}
