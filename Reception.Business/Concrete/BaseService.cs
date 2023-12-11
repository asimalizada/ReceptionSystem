using Reception.Business.Asbtract;
using Reception.DataAccess.Abstract;
using Reception.Entities.Abstract;

namespace Reception.Business.Concrete;

public class BaseService<TEntity, TRepository> : IBaseService<TEntity>
    where TEntity : class, IEntity, new()
    where TRepository : class, IEntityRepository<TEntity>, new()
{
    private readonly TRepository _repository;

    public BaseService(TRepository repository)
    {
        _repository = repository;
    }

    public TEntity Add(TEntity entity)
    {

    }

    public TEntity Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public TEntity Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
