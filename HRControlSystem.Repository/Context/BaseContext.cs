using HRControlSystem.Model.Entities;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace HRControlSystem.Repository.Context;

public class BaseContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server=localhost;port=3306;database=HRSchema;user=root;password=Pass1234";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}