using HRControlSystem.Application.Abstracts;
using HRControlSystem.Model.Entities;
using HRControlSystem.Repository.Abstracts;

namespace HRControlSystem.Application.Concrete;

public class UserApplication : IUserApplication
{
    private IUserRepository _userRepository { get; set; }
    public UserApplication(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public bool Create(User user)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id, User user)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(int id, User user)
    {
        throw new NotImplementedException();
    }
}