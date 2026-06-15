using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Version;

namespace TeamR.Repository.Entities;

public class VersionRepository(ApplicationContext context) : Base.Repository<Guid, TeamR.Domain.Entities.Version.Version, VersionColumn>(context)
{
}