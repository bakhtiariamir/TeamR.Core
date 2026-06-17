using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Account;

public class Role : Info<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }
}