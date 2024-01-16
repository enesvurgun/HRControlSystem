using HRControlSystem.Model.Entities;

namespace HRControlSystem.Application.Abstracts;

public interface IEmployeeApplication
{
    IEnumerable<Employee> GetAll();
    Employee GetById(int id);
    bool Create(Employee employee);
    bool Update(int id, Employee employee);
    bool Delete(int id, Employee employee);
}