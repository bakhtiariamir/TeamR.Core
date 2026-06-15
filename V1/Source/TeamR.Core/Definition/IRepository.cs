using System.Linq.Expressions;
using TeamR.Core.Object;

namespace TeamR.Core.Definition;

public interface IRepository<in TType, TEntity, TEnum>  
    where TEntity : class, IEntity<TType>
    where TEnum : Enum
{
    Task UpdateAsync(TType id, TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, List<OrderBy<TEnum>>? orderBy = null, int? skip = null, int? take = null);
}