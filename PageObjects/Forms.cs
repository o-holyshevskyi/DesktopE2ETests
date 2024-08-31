using PageObjects.Main;
using PageObjects.ResultField;
using Selectors;

namespace PageObjects;

internal class Forms(ISelectorService client) : IForm
{
    private readonly ISelectorService _selectorService = client ?? throw new ArgumentNullException(nameof(client));

    public INumbers Numbers => new Numbers(_selectorService);
    public IResult Result => new Result(_selectorService);
}
