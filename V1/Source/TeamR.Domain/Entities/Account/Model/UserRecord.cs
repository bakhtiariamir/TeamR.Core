using TeamR.Core.Type;

namespace TeamR.Domain.Entities.Account.Model;

public sealed record UserRecord(string Name, string LastName,string Address, string Mobile, SexType Sex, DateTime BirthDate, Account? Account, string? Latitude, string? Longitude, string? Altitude);