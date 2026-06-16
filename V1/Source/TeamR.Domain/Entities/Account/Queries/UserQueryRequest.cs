using MediatR;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UserQueryRequest(Guid Id) : IRequest<User>;