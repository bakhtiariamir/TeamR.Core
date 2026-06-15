using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Structure;

public interface IDocumentRepository : IRepository<Guid, Document, DocumentColumn>
{
}