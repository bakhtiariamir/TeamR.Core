using TeamR.Domain.Entities.Account;
using TeamR.Domain.Entities.Info;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Domain.Entities.Access;

public class RolePermission : Info<Guid>
{
    public Guid RoleId { get; private set; }

    public Guid PermissionId { get; private set; }

    public Role Role { get; private set; }

    public Permission Permission { get; private set; }
}