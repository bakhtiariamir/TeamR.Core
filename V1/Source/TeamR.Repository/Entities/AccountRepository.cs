using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Account;

namespace TeamR.Repository.Entities;

public class AccountRepository(ApplicationContext context) : Base.Repository<Guid, Account, AccountColumn>(context), IAccountRepository
{
}