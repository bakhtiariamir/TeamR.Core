using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Version;

public interface IVersionRepository : IRepository<Guid, Version, VersionColumn>
{
    
}