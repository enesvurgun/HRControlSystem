using HRControlSystem.Application.Abstracts;
using HRControlSystem.Application.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HRControlSystem.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private IEmployeeApplication _employeeApplication { get; set; }
    public EmployeeController(IEmployeeApplication employeeApplication)
    {
        _employeeApplication = employeeApplication;
    }
}