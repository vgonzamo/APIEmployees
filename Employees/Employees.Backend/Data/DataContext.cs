using Employees.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employees.backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<tblEmployees> employees { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<tblEmployees>().Property(static e => e.Salary).HasColumnType("decimal(18,2)");
    }



}