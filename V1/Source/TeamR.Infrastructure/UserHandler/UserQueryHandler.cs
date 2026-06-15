using MediatR;
using Microsoft.Identity.Client;
using TeamR.Domain.Entities.Account;
using TeamR.Domain.Entities.Account.Queries;

namespace TeamR.Infrastructure.UserHandler;

public class UserQueryHandler(IUserRepository repository) : IRequestHandler<UserQueryRequest, User>
{
    public async Task<User> Handle(UserQueryRequest request, CancellationToken cancellationToken)
    {
        return await repository.FirstOrDefaultAsync(item => item.Id == request.Id);
    }
}