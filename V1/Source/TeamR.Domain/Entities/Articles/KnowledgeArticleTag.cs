using TeamR.Domain.Entities.Info;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Domain.Entities.Articles;

public class KnowledgeArticleTag : Info<Guid>
{
    public Guid KnowledgeArticleId { get;set; }

    public Guid TagId { get;set; }

    public KnowledgeArticle KnowledgeArticle { get;set; }

    public Tag Tag { get;set; }
    
    public int Point { get; set; }
}