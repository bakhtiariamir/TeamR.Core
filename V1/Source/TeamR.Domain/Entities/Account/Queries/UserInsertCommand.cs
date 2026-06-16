using MediatR;
using TeamR.Domain.Entities.Account.Model;

namespace TeamR.Domain.Entities.Account.Queries;

public sealed record UserInsertCommand(UserRecord User) : IRequest<User>;

public sealed record AccountInsertRecord(AccountRecord AccountRecord) : IRequest<Account>;