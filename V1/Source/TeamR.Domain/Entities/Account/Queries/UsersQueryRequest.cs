using MediatR;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UsersQueryRequest() : IRequest<IEnumerable<User>>;