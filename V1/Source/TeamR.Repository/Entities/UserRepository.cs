using TeamR.Database.Dataset;
using TeamR.Domain.Entities.Account;

namespace TeamR.Repository.Entities;

public class UserRepository(ApplicationContext context) : Base.Repository<Guid, User, UserColumn>(context), IUserRepository
{
}