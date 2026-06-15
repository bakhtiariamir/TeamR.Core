using TeamR.Core.Object;

namespace TeamR.Domain.Entities.Info;

public abstract class Info<TType> : Entity<TType>
{
    public DateTime CreateDate { get; set; }
   
    public DateTime? ModifiedDate { get; set; }
    
    public Guid UserId { get; set; }
    
    public bool IsActive { get; set; }
     
    public bool IsDeleted { get; set; }
}