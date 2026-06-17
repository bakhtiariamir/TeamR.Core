using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Structure;

public class DocumentPermission : Info<Guid>
{
    public Guid DocumentId { get; private set; }

    public Guid? DepartmentId { get; private set; }

    public Guid? PostId { get; private set; }

    public Guid? UserId { get; private set; }

    public AccessLevel AccessLevel { get; private set; }
}