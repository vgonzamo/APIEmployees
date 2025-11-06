using System.Reflection.Emit;
using Employees.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employees.Backend.Data;

public class DataContext : IdentityDbContext<User>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<tblEmployees> employees { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<tblEmployees>().Property(static e => e.Salary).HasColumnType("decimal(18,2)");
        DisableCascading(modelBuilder);
    }

    private void DisableCascading(ModelBuilder modelBuilder)

    {

        var relationship = modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys());

        foreach (var item in relationship)

        {

            item.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }

   


}