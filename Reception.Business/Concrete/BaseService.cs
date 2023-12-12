using Reception.Business.Asbtract;
using Reception.DataAccess.Abstract;
using Reception.Entities.Abstract;

namespace Reception.Business.Concrete;

public class BaseService<TEntity, TRepository> : IBaseService<TEntity>
    where TEntity : class, IEntity, new()
    where TRepository : class, IEntityRepository<TEntity>
{
    private readonly TRepository _repository;

    public BaseService(TRepository repository)
    {
        _repository = repository;
    }

    public TEntity Add(TEntity entity)
    {
        var result = _repository.Add(entity);

        return result;
    }

    public void Delete(TEntity entity)
    {
        _repository.Delete(entity);
    }

    public TEntity Get(int id)
    {
        var result = _repository.Get(e => e.Id == id);
        return result;
    }

    public List<TEntity> GetAll()
    {
        var list = _repository.GetAll();
        return list;
    }

    public TEntity Update(TEntity entity)
    {
        var result= _repository.Update(entity);
        return result;
    }
}
