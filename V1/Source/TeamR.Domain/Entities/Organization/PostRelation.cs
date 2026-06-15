using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Organization;

public class PostRelation : Info<Guid>
{
    public PostRelationType Type { get; set; }
    public Guid? PostId { get; set; }
    public virtual Post? Post { get; set; }
}