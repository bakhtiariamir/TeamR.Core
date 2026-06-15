using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Repository.Entities;

public class DepartmentRepository(ApplicationContext context) : Base.Repository<Guid, Department, DepartmentColumn>(context)
{
}