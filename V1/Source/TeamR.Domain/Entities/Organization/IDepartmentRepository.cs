using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Organization;

public interface IDepartmentRepository : IRepository<Guid, Department, DepartmentColumn>
{
}