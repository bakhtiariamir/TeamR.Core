using Microsoft.EntityFrameworkCore;
using TeamR.Core.Object;
using TeamR.Core.Type;

namespace TeamR.Domain.Entities.Structure;

[Index(nameof(Name), nameof(Url))]
public class Document : Entity<Guid>
{
    public string Name
    {
        get;
        set;
    }

    public EextensionType Extension
    {
        get;
        set;
    } 
    
    public string? Description
    {
        get; 
        set;
    }

    public string Url
    {
        get;
        set;
    }
    
    public DocumentType DocumentType
    {
        get;
        set;
    }

    public Guid VersionId
    {
        get;
        set;
    }
    
    public virtual Version.Version Version
    {
        get;
        set;
    }
    
    public byte[] Body
    {
        get;
        set;
    }
    
    public Guid FolderId
    {
        get;
        set;
    }

    public virtual Folder Folder
    {
        get;
        set;
    }
}

//string result = System.Text.Encoding.UTF8.GetString(byteArray);

//var sourceFile = Path.Combine(directory, "Files", "source.png");
//var destinationPath = Path.Combine(directory, "Files");
//using var fileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
//using var memoryStream = new MemoryStream();
//fileStream.CopyTo(memoryStream);

//  public static void CopyToFile(MemoryStream stream, string path)
//{
//    using var fileStream = File.Create(path);
//    stream.Position = 0;
//   stream.CopyTo(fileStream);
//}

//public static void WriteToFile(MemoryStream stream, string path)
//{
//    using var fileStream = File.Create(path);
//    fileStream.Write(stream.ToArray());
//}