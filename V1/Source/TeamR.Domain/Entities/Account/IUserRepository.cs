using TeamR.Core.Definition;

namespace TeamR.Domain.Entities.Account;

public interface IUserRepository : IRepository<Guid, User, UserColumn>
{
}