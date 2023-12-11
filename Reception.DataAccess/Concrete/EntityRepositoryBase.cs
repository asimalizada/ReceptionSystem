using Microsoft.EntityFrameworkCore;
using Reception.DataAccess.Abstract;
using Reception.Entities.Abstract;
using System.Linq.Expressions;

namespace Reception.DataAccess.Concrete;

public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext
{
    public TContext Context { get; set; }

    public EntityRepositoryBase()
    {
        
    }

    public TEntity Add(TEntity entity)
    {
        var addedEntity = Context.Entry(entity); 
        addedEntity.State = EntityState.Added;
        Context.SaveChanges();

        return entity;
    }

    public void Delete(TEntity entity)
    {
        var deletedEntity = Context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        Context.SaveChanges();

    
    }

    public TEntity Get(Expression<Func<TEntity, bool>> predicate)
    {
        return Context.Set<TEntity>().FirstOrDefault(predicate);
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
    {
        return predicate == null
            ? Context.Set<TEntity>().ToList()
            : Context.Set<TEntity>().Where(predicate).ToList();
    }

    public TEntity Update(TEntity entity)
    {
        var updatedEntity = Context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        Context.SaveChanges();

        return entity;
    }
}
