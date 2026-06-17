using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Structure;

public class DocumentVersion : Info<Guid>
{
    public string VersionNumber { get;set; }

    public string FileName { get;set; }

    public string FilePath { get;set; }

    public long FileSize { get;set; }

    public bool IsCurrent { get;set; }

    public virtual Document Document { get;set; }
}