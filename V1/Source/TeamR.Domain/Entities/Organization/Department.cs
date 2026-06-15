using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Organization;

public class Department : Info<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid ChartId { get; set; }
    public Chart Chart { get; set; }
    public Guid? ParentId { get; set; }
    public Department? Parent { get; set; }
    
    public virtual ICollection<Post> Posts { get; set; }
}