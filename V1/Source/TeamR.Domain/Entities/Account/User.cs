using TeamR.Core.Object;
using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Account;

public class User : Info<Guid>
{ 
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Mobile { get; set; }
    public SexType Sex { get; set; }
    public DateTime Birthday { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude  { get; set; }
    public string? Altitude  { get; set; }
    public Guid AccountId { get; set; }
    public virtual Account Account { get; set; }
}