using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Organization;

public class Department : Info<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    public Guid? ParentId { get; set; }
    public virtual Department? Parent { get; set; }
    
    public ICollection<Department> Children { get; private set; } = [];
    public virtual ICollection<Post> Posts { get; set; }
}