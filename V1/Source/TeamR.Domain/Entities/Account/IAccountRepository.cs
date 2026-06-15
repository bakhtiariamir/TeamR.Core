using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Account;

public interface IAccountRepository : IRepository<Guid, Account, AccountColumn>
{
    
}