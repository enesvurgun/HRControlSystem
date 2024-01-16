using HRControlSystem.Repository.Abstracts;
using HRControlSystem.Repository.Context;

namespace HRControlSystem.Repository.Concrete;

public class Repository<T> : IRepository<T> where T : class, new()
{
    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id, T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        using (var context = new BaseContext())
        {
            return context.Set<T>().ToList();
        }
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, T entity)
    {
        throw new NotImplementedException();
    }
}