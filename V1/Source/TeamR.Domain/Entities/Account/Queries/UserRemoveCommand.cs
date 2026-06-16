using MediatR;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UserRemoveCommand(Guid Id) : IRequest;