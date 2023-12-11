using Reception.Entities.Abstract;
using System.Linq.Expressions;

namespace Reception.DataAccess.Abstract;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
    T Add(T entity);
    T Update(T entity);
    void Delete(T entity);
    T Get(Expression<Func<T, bool>> predicate);
    List<T> GetAll(Expression<Func<T, bool>> predicate = null);
}



//he

interface ITesting
{
    void Test();
}

class Testing : ITesting
{
    public void Test()
    {
        Console.WriteLine("Tested!");
    }
}

class MyClass
{
    public void Temp()
    {
        ITesting test = new Testing();

        test.Test();
    }

}



