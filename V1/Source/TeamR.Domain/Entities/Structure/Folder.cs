using Microsoft.EntityFrameworkCore;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Structure;

[Index(nameof(Name))]
public class Folder : Info<Guid>
{
    public string Name { get; set; }
    public string Path { get; set; } = "./";
    public Guid? ParentId { get; set; }
    public virtual Folder? Parent { get; set; }
    public bool IsHidden { get; set; }
    public string? Password { get; set; }
}