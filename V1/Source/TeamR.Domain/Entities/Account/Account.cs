using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Account;

public class Account : Info<Guid>
{
    public string Username { get; set; }
    
    public string Password { get; set; }

    public string Email { get; set; }
    
    public Guid UserId { get; set; }
    
    public virtual User User { get; set; }
    
    public byte[]? Image { get; set; }
    public bool UseGravatar { get; set; }
}