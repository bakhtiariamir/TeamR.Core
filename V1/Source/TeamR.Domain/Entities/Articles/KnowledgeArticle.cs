using TeamR.Core.Type;
using TeamR.Domain.Entities.Info;
using TeamR.Domain.Entities.Organization;
using TeamR.Domain.Entities.Structure;

namespace TeamR.Domain.Entities.Articles;

public class KnowledgeArticle : Info<Guid>
{
    public string Title { get;set; }

    public string Summary { get;set; }

    public string Content { get;set; }


    public Guid CompanyId { get;set; }

    public KnowledgeArticleStatus Status { get;set; }

    public Guid FolderId { get;set; }

    public virtual Folder Folder { get;set; }

    public virtual Company Company { get;set; }

    public ICollection<KnowledgeArticleTag> Tags { get; set; } = [];

    public ICollection<KnowledgeArticleRevision> Revisions { get; set; } = [];
}