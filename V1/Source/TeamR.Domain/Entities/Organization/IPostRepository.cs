using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Organization;

public interface IPostRepository : IRepository<Guid, Post, PostColumn>
{
}