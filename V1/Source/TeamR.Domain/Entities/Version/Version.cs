using TeamR.Core.Object;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Version;

public class Version : Info<Guid>
{
    public string Major
    {
        get; 
        set;
    }
    
    public string Minor
    {
        get; 
        set;
    }
    
    public string Patch
    {
        get; 
        set;
    }

    public DateTime ReleaseDate
    {
        get;
        set;
    }

    public virtual ICollection<Structure.Document> Documents
    {
        get;
        set;
    }
}