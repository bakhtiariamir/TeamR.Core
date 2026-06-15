using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Organization;
using Version = System.Version;

namespace TeamR.Repository.Entities;

public class PostRepository(ApplicationContext context) : Base.Repository<Guid, Post, PostColumn>(context)
{
}