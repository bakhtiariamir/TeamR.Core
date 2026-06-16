namespace TeamR.Domain.Entities.Account.Model;

public sealed record AccountRecord(string UserName, string Password,string Email, User User, byte[] Image, bool UseGravatar);