using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Organization;

public class Post : Info<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid ChartId { get; set; }
    public virtual Chart Chart { get; set; }
    
    public Guid DepartmentId { get; set; }
    public virtual Department Department { get; set; }
    public int Capacity { get; set; }
    
    public virtual ICollection<PostRelation> Relations { get; set; }
}