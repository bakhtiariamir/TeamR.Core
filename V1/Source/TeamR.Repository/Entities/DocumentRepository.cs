using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Repository.Entities;

public class DocumentRepository(ApplicationContext context) : Base.Repository<Guid, Document, DocumentColumn>(context)
{
}