using Employeess.backend.Data;
using Employeess.Shared.Entites;

namespace Employeess.Backend.Data;

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

            _context.employees.AddRange(new Employee { FirstName = "Juliana", LastName = "Castaño", IsActive = true, HireDate = DateTime.Now, Salary = 1_250_000 },
                                        new Employee { FirstName = "Juan", LastName = "Martínez", IsActive = true, HireDate = DateTime.Now, Salary = 1_400_000 },
                                        new Employee { FirstName = "Justina", LastName = "Gómez", IsActive = false, HireDate = new DateTime(2021, 2, 17), Salary = 1_180_000 },
                                        new Employee { FirstName = "Julián", LastName = "Salazar", IsActive = true, HireDate = new DateTime(2020, 6, 25), Salary = 1_600_000 },
                                        new Employee { FirstName = "Juvenal", LastName = "Ramírez", IsActive = false, HireDate = new DateTime(2019, 9, 14), Salary = 1_300_000 },
                                        new Employee { FirstName = "Julia", LastName = "Fernández", IsActive = true, HireDate = new DateTime(2018, 12, 5), Salary = 1_450_000 },
                                        new Employee { FirstName = "Junior", LastName = "Morales", IsActive = true, HireDate = new DateTime(2017, 3, 19), Salary = 1_350_000 },
                                        new Employee { FirstName = "Julieth", LastName = "Rojas", IsActive = false, HireDate = new DateTime(2016, 7, 29), Salary = 1_280_000 },
                                        new Employee { FirstName = "Juscelino", LastName = "Santos", IsActive = true, HireDate = new DateTime(2015, 11, 10), Salary = 1_500_000 },
                                        new Employee { FirstName = "Justo", LastName = "Vargas", IsActive = true, HireDate = new DateTime(2014, 5, 7), Salary = 1_370_000 });
        await _context.SaveChangesAsync();
    }
}