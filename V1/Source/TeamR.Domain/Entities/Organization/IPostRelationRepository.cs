using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Organization;

public interface IPostRelationRepository : IRepository<Guid, PostRelation, PostRelationColumn>
{
}