using Reception.Entities.Abstract;

namespace Reception.Business.Asbtract;

public interface IBaseService<T> where T : class, IEntity, new()
{
    T Add(T entity);
    T Delete(T entity);
    T Update(T entity);
    T Get(int id);
    List<T> GetAll();
}