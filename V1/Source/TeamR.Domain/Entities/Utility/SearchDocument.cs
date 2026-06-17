namespace TeamR.Domain.Entities.Utility;

public class SearchDocument
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Type { get; set; }

    public Guid CompanyId { get; set; }

    public DateTime IndexedAt { get; set; }
}