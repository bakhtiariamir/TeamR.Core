using System.Linq.Expressions;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using TeamR.Core.Definition;
using TeamR.Core.Object;
using TeamR.Core.Type;
using TeamR.Database.Dataset;

namespace TeamR.Repository.Base;

public abstract class Repository<TType, TEntity, TEnum>(ApplicationContext context)
    : IRepository<TType, TEntity, TEnum> 
    where TEntity : Entity<TType>
    where TEnum : Enum
{

    public async Task InsertAsync(TEntity entity)
    {
        try
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task UpdateAsync(TType id, TEntity entity)
    {
        try
        {
            var record = await context.Set<TEntity>().FirstOrDefaultAsync(entity => entity.Id.Equals(id));
            if (record == null) throw new ArgumentNullException("Id is empty or entity with argument not exist");
            context.Set<TEntity>().Attach(entity);
            context.Set<TEntity>().Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

            throw new ArgumentNullException("Id is empty or entity with argument not exist");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task DeleteAsync(TEntity entity)
    {
        try
        {
            var record = await context.Set<TEntity>().FirstOrDefaultAsync(entity => entity.Id.Equals(entity.Id));
            if (record == null) throw new ArgumentNullException("Id is empty or entity with argument not exist");
            context.Remove(entity);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    public async Task<TEntity> Single(TType id)
    {
        try
        {
            return await context.Set<TEntity>().FirstOrDefaultAsync(item => item.Id.Equals(id));
        }
        catch (Exception eX)
        {
            throw eX;
        }
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {
            var items = context.Set<TEntity>();
            return await items.ToListAsync();
        }
        catch (Exception eX)
        {
            throw eX;
        }
    }
    

    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, List<OrderBy<TEnum>>? orderBy = null, int? skip = null, int? take = null) 
    {
        try
        {
            var query = context.Set<TEntity>().Where(predicate);
            if (orderBy != null)
            {
                foreach (var order in orderBy)
                {
                    switch (order.Direction)
                    {
                        case OrderType.asc:
                            var parameter = typeof(TEntity).GetProperty(nameof(order.Column));
                            if (parameter != null)
                                query = query.OrderBy(item =>
                                    parameter.PropertyType.GetProperty(parameter.Name).GetValue(item));
                            break;
                        case OrderType.desc:
                            var param = typeof(TEntity).GetProperty(nameof(order.Column));
                            if (param != null)
                                query = query.OrderByDescending(item =>
                                    param.PropertyType.GetProperty(param.Name).GetValue(item));
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            if (skip.HasValue && take.HasValue)
            {
                return query.Skip(skip.Value).Take(take.Value);
            }

            return query.AsEnumerable();
        }
        catch (Exception eX)
        {
            throw eX;
        }
    }
}