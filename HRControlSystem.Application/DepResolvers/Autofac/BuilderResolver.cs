using Autofac;
using HRControlSystem.Application.Abstracts;
using HRControlSystem.Application.Concrete;
using HRControlSystem.Repository.Abstracts;
using HRControlSystem.Repository.Concrete;

namespace HRControlSystem.Application.Autofac;

public class BuilderResolver : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<EmployeeApplication>().As<IEmployeeApplication>();
        builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();

        builder.RegisterType<UserApplication>().As<IUserApplication>();
        builder.RegisterType<UserRepository>().As<IUserRepository>();
    }
}