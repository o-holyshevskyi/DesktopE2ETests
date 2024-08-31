using PageObjects.Main;
using PageObjects.ResultField;

namespace PageObjects;

public interface IForm
{
    INumbers Numbers { get; }
    IResult Result { get; }
}
