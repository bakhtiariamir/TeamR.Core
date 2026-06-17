using TeamR.Core.Object;

namespace TeamR.Domain.Entities.Structure;

public class Tag : Entity<Guid>
{
    public string Name { get; set; }
}