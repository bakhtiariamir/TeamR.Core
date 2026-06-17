using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Domain.Entities.Access;

public class PostPermission : Info<Guid>
{
    public Guid PostId { get; private set; }

    public Guid PermissionId { get; private set; }

    public virtual Post Post { get; private set; }

    public Permission Permission { get; private set; }
}

public class DocumentAccessPolicy : Info<Guid>
{
    public Guid DocumentId { get; private set; }

    public Guid DepartmentId { get; private set; }

    public AccessLevel AccessLevel { get; private set; }
}