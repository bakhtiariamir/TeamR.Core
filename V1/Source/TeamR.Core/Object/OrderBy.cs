using TeamR.Core.Type;

namespace TeamR.Core.Object;

public abstract class OrderBy<TEnum> 
    where TEnum : Enum
{
    public TEnum Column { get; set; }

    public OrderType Direction { get; set; }
    
    
}