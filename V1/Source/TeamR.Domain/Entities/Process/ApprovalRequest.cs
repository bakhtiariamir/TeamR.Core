using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Process;

public class ApprovalRequest : Info<Guid>
{
    public Guid TargetId { get; set; }

    public ApprovalTargetType TargetType { get; set; }

    public string RequestedBy { get; set; }

    public string ApprovedBy { get; set; }

    public ApprovalStatus Status { get; set; }

    public string Comment { get; set; }
}