namespace TeamR.Core.Definition;

public interface IEntity<TType>
{
    TType Id { get; set; }
}