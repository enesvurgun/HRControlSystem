using HRControlSystem.Application.Abstracts;
using HRControlSystem.Model.Entities;
using HRControlSystem.Repository.Abstracts;

namespace HRControlSystem.Application.Concrete;

public class EmployeeApplication : IEmployeeApplication
{
    private IEmployeeRepository _employeeRepository { get; set; }
    public EmployeeApplication(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public bool Create(Employee employee)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id, Employee employee)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetAll()
    {
        throw new NotImplementedException();
    }

    public Employee GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(int id, Employee employee)
    {
        throw new NotImplementedException();
    }
}