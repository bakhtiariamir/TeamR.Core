using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Repository.Entities;

public class PostRelationRepository(ApplicationContext context) : Base.Repository<Guid, PostRelation, PostRelationColumn>(context)
{
}