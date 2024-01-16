using HRControlSystem.Model.Entities;

namespace HRControlSystem.Application.Abstracts;

public interface IUserApplication
{
    IEnumerable<User> GetAll();
    User GetById(int id);
    bool Create(User user);
    bool Update(int id, User user);
    bool Delete(int id, User user);
}