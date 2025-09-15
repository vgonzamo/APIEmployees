
using Orders.backend.Data;
using Orders.Shared.Entites;
using System.ComponentModel.DataAnnotations;

namespace Employees.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckEmployeesAsync();

    }
    private async Task CheckEmployeesAsync()
    {
        if (!_context.employees.Any())

            _context.employees.AddRange(new Employee { FristName = "Juliana", LastName = "Castaño", IsActive = true, HireDate = new DateTime(2023, 10, 12), Salary = 1_250_000 },
                                        new Employee { FristName = "Juan", LastName = "Martínez", IsActive = true, HireDate = new DateTime(2022, 8, 3), Salary = 1_400_000 },
                                        new Employee { FristName = "Justina", LastName = "Gómez", IsActive = false, HireDate = new DateTime(2021, 2, 17), Salary = 1_180_000 },
                                        new Employee { FristName = "Julián", LastName = "Salazar", IsActive = true, HireDate = new DateTime(2020, 6, 25), Salary = 1_600_000 },
                                        new Employee { FristName = "Juvenal", LastName = "Ramírez", IsActive = false, HireDate = new DateTime(2019, 9, 14), Salary = 1_300_000 },
                                        new Employee { FristName = "Julia", LastName = "Fernández", IsActive = true, HireDate = new DateTime(2018, 12, 5), Salary = 1_450_000 },
                                        new Employee { FristName = "Junior", LastName = "Morales", IsActive = true, HireDate = new DateTime(2017, 3, 19), Salary = 1_350_000 },
                                        new Employee { FristName = "Julieth", LastName = "Rojas", IsActive = false, HireDate = new DateTime(2016, 7, 29), Salary = 1_280_000 },
                                        new Employee { FristName = "Juscelino", LastName = "Santos", IsActive = true, HireDate = new DateTime(2015, 11, 10), Salary = 1_500_000 },
                                        new Employee { FristName = "Justo", LastName = "Vargas", IsActive = true, HireDate = new DateTime(2014, 5, 7), Salary = 1_370_000 });
        await _context.SaveChangesAsync();
    }
}