using TeamR.Core.Type;

namespace TeamR.Core.Object;

public class SortCriteria
{
    public string Column
    {
        get;
        set;
    }

    public OrderType Order
    {
        get;
        set;
    }
}