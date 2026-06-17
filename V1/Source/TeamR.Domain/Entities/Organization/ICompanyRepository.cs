using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Organization;

public interface ICompanyRepository : IRepository<Guid, Company, CompanyColumn>
{
}