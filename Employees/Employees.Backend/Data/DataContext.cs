using Employeess.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace Employeess.backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Employee> employees { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>().Property(static e => e.Salary).HasColumnType("decimal(18,2)");
    }



}