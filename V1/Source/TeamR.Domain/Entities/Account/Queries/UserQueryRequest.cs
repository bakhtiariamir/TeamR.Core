using MediatR;
using TeamR.Core.Type;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UserQueryRequest(Guid Id) : IRequest<User>;

public sealed record UsersQueryRequest() : IRequest<IEnumerable<User>>;

public sealed record UserInsertCommand(NewUser User) : IRequest<User>;


public sealed record NewUser(string Name, string LastName,string Address, string Mobile, SexType Sex, DateTime BirthDate, Account? Account, string? Latitude, string? Longitude, string? Altitude);
public sealed record NewAccount(string UserName, string Password,string Email, User User, byte[] Image, bool UseGravatar);
