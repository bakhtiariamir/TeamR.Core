using TeamR.Domain.Entities.Info;

namespace TeamR.Domain.Entities.Articles;

public class KnowledgeArticleRevision : Info<Guid>
{
    public Guid KnowledgeArticleId { get;set; }

    public string Content { get;set; }

    public int RevisionNumber { get;set; }

    public KnowledgeArticle KnowledgeArticle { get;set; }
}