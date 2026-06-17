using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Organization;

namespace TeamR.Repository.Entities;

public class CompanyRepository(ApplicationContext context) : Base.Repository<Guid, Company, CompanyColumn>(context)
{
}