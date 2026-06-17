using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Structure;

public class DocumentTag : Info<Guid>
{
    public Guid DocumentId { get; private set; }

    public Guid TagId { get; private set; }

    public Document Document { get; private set; }

    public Tag Tag { get; private set; }
    
    public int Point { get; set; }
}