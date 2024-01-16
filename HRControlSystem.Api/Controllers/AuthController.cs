using HRControlSystem.Application.Abstracts;
using HRControlSystem.Application.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HRControlSystem.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private IUserApplication _userApplication { get; set; }
    public AuthController(IUserApplication userApplication)
    {
        _userApplication = userApplication;
    }
}