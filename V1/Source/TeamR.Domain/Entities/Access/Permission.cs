using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Access;

public class Permission : Info<Guid>
{
    public string Code { get; set; }

    public string Name { get; set; }
}