using HRControlSystem.Application.Abstracts;
using HRControlSystem.Application.Concrete;
using HRControlSystem.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HRControlSystem.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserApplication _userApplication { get; set; }
    public UserController(IUserApplication userApplication)
    {
        _userApplication = userApplication;
    }

    [HttpGet]
    public IEnumerable<User> GetUsers() {
        return _userApplication.GetAll();
    }
}