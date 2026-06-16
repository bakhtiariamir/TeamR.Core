using MediatR;
using TeamR.Domain.Entities.Account.Model;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UserUpdateCommand(Guid Id, UserRecord User) : IRequest<User>;