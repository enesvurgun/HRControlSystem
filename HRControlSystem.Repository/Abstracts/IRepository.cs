namespace HRControlSystem.Repository.Abstracts;

public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Create(T entity);
    void Update(int id, T entity);
    void Delete(int id, T entity);
}