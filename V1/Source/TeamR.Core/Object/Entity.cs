using TeamR.Core.Definition;

namespace TeamR.Core.Object;

public class Entity<TType> : IEntity<TType>
{
    public TType Id { get; set; }
}