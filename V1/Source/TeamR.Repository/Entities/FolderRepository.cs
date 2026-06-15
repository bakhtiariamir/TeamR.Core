using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Repository.Entities;

public class FolderRepository(ApplicationContext context) : Base.Repository<Guid, Folder, FolderColumn>(context)
{
}