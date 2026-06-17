using TeamR.Domain.Entities.Info;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Domain.Entities.Account;

public class UserRole : Info<Guid>
{
    public Guid UserId { get; private set; }

    public Guid RoleId { get; private set; }

    public virtual User User { get; private set; }

    public virtual Role Role { get; private set; }
}