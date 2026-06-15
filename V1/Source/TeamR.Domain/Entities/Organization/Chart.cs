using Microsoft.VisualBasic.CompilerServices;
using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Organization;

public class Chart : Info<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ChartType ChartType { get; set; }
    
    public virtual ICollection<Department> Departments { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
}