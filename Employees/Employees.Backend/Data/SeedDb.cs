using Employees.backend.Data;
using Employees.Shared.Entities;

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

            _context.employees.AddRange(
                new tblEmployees { FirstName = "Juliana", LastName = "Castaño", IsActive = true, HireDate = DateTime.Now, Salary = 1_250_000 },
                new tblEmployees { FirstName = "Juan", LastName = "Martínez", IsActive = true, HireDate = DateTime.Now, Salary = 1_400_000 },
                new tblEmployees { FirstName = "Justina", LastName = "Gómez", IsActive = false, HireDate = new DateTime(2021, 2, 17), Salary = 1_180_000 },
                new tblEmployees { FirstName = "Julián", LastName = "Salazar", IsActive = true, HireDate = new DateTime(2020, 6, 25), Salary = 1_600_000 },
                new tblEmployees { FirstName = "Juvenal", LastName = "Ramírez", IsActive = false, HireDate = new DateTime(2019, 9, 14), Salary = 1_300_000 },
                new tblEmployees { FirstName = "Julia", LastName = "Fernández", IsActive = true, HireDate = new DateTime(2018, 12, 5), Salary = 1_450_000 },
                new tblEmployees { FirstName = "Junior", LastName = "Morales", IsActive = true, HireDate = new DateTime(2017, 3, 19), Salary = 1_350_000 },
                new tblEmployees { FirstName = "Julieth", LastName = "Rojas", IsActive = false, HireDate = new DateTime(2016, 7, 29), Salary = 1_280_000 },
                new tblEmployees { FirstName = "Juscelino", LastName = "Santos", IsActive = true, HireDate = new DateTime(2015, 11, 10), Salary = 1_500_000 },
                new tblEmployees { FirstName = "Justo", LastName = "Vargas", IsActive = true, HireDate = new DateTime(2014, 5, 7), Salary = 1_370_000 },
                new tblEmployees { FirstName = "Valentina", LastName = "Montoya", IsActive = true, HireDate = new DateTime(2019, 3, 15), Salary = 2_100_000 },
                new tblEmployees { FirstName = "Santiago", LastName = "Ramírez", IsActive = false, HireDate = new DateTime(2016, 7, 9), Salary = 1_850_000 },
                new tblEmployees { FirstName = "Lucía", LastName = "Gómez", IsActive = true, HireDate = new DateTime(2020, 1, 20), Salary = 1_500_000 },
                new tblEmployees { FirstName = "Mateo", LastName = "Torres", IsActive = true, HireDate = new DateTime(2021, 9, 2), Salary = 2_450_000 },
                new tblEmployees { FirstName = "Laura", LastName = "Castaño", IsActive = true, HireDate = new DateTime(2018, 6, 12), Salary = 1_950_000 },
                new tblEmployees { FirstName = "Daniel", LastName = "Ospina", IsActive = false, HireDate = new DateTime(2015, 11, 3), Salary = 1_300_000 },
                new tblEmployees { FirstName = "Camila", LastName = "Hernández", IsActive = true, HireDate = new DateTime(2023, 2, 18), Salary = 1_600_000 },
                new tblEmployees { FirstName = "Nicolás", LastName = "Restrepo", IsActive = true, HireDate = new DateTime(2017, 5, 7), Salary = 2_000_000 },
                new tblEmployees { FirstName = "Sara", LastName = "Marín", IsActive = false, HireDate = new DateTime(2014, 10, 28), Salary = 1_200_000 },
                new tblEmployees { FirstName = "Andrés", LastName = "Giraldo", IsActive = true, HireDate = new DateTime(2022, 8, 5), Salary = 1_850_000 },
                new tblEmployees { FirstName = "Jesus", LastName = "Quintero", IsActive = true, HireDate = new DateTime(2020, 12, 10), Salary = 1_730_000 },
                new tblEmployees { FirstName = "Juan", LastName = "Pérez", IsActive = true, HireDate = new DateTime(2013, 4, 23), Salary = 2_800_000 },
                new tblEmployees { FirstName = "Sofía", LastName = "López", IsActive = true, HireDate = new DateTime(2021, 3, 1), Salary = 1_950_000 },
                new tblEmployees { FirstName = "Tomás", LastName = "Jiménez", IsActive = false, HireDate = new DateTime(2012, 9, 13), Salary = 1_250_000 },
                new tblEmployees { FirstName = "Mariana", LastName = "Zapata", IsActive = true, HireDate = new DateTime(2023, 1, 4), Salary = 1_700_000 },
                new tblEmployees { FirstName = "Esteban", LastName = "Cardona", IsActive = true, HireDate = new DateTime(2017, 6, 21), Salary = 1_980_000 },
                new tblEmployees { FirstName = "Juliana", LastName = "Arias", IsActive = true, HireDate = new DateTime(2019, 10, 30), Salary = 2_150_000 },
                new tblEmployees { FirstName = "Felipe", LastName = "Córdoba", IsActive = false, HireDate = new DateTime(2016, 4, 11), Salary = 1_450_000 },
                new tblEmployees { FirstName = "Daniela", LastName = "Vélez", IsActive = true, HireDate = new DateTime(2020, 7, 9), Salary = 1_900_000 },
                new tblEmployees { FirstName = "Samuel", LastName = "Ruiz", IsActive = true, HireDate = new DateTime(2018, 2, 26), Salary = 1_850_000 },
                new tblEmployees { FirstName = "Juan Carlos", LastName = "Patiño", IsActive = false, HireDate = new DateTime(2015, 8, 19), Salary = 1_300_000 },
                new tblEmployees { FirstName = "Juan Pablo", LastName = "Cano", IsActive = true, HireDate = new DateTime(2019, 11, 2), Salary = 2_250_000 },
                new tblEmployees { FirstName = "Gabriela", LastName = "García", IsActive = true, HireDate = new DateTime(2021, 9, 17), Salary = 1_600_000 },
                new tblEmployees { FirstName = "Emilio", LastName = "Londoño", IsActive = true, HireDate = new DateTime(2018, 12, 6), Salary = 1_750_000 },
                new tblEmployees { FirstName = "Antonia", LastName = "Pérez", IsActive = true, HireDate = new DateTime(2022, 3, 10), Salary = 1_580_000 },
                new tblEmployees { FirstName = "Simón", LastName = "Mora", IsActive = true, HireDate = new DateTime(2014, 5, 7), Salary = 1_370_000 },
                new tblEmployees { FirstName = "Martina", LastName = "Álvarez", IsActive = true, HireDate = new DateTime(2023, 4, 15), Salary = 1_990_000 },
                new tblEmployees { FirstName = "Daniel", LastName = "Soto", IsActive = false, HireDate = new DateTime(2012, 8, 20), Salary = 1_100_000 },
                new tblEmployees { FirstName = "Liliana", LastName = "Mejía", IsActive = true, HireDate = new DateTime(2018, 6, 30), Salary = 2_100_000 },
                new tblEmployees { FirstName = "Valentín", LastName = "Morales", IsActive = true, HireDate = new DateTime(2019, 5, 22), Salary = 1_720_000 },
                new tblEmployees { FirstName = "Laura", LastName = "Agudelo", IsActive = true, HireDate = new DateTime(2017, 1, 19), Salary = 1_830_000 },
                new tblEmployees { FirstName = "Manuel", LastName = "Núñez", IsActive = false, HireDate = new DateTime(2014, 11, 25), Salary = 1_250_000 },
                new tblEmployees { FirstName = "Paula", LastName = "Duque", IsActive = true, HireDate = new DateTime(2021, 2, 8), Salary = 1_870_000 },
                new tblEmployees { FirstName = "Adriana", LastName = "Villegas", IsActive = true, HireDate = new DateTime(2015, 6, 4), Salary = 1_950_000 },
                new tblEmployees { FirstName = "Cristian", LastName = "Restrepo", IsActive = true, HireDate = new DateTime(2020, 8, 12), Salary = 1_770_000 },
                new tblEmployees { FirstName = "Andres", LastName = "Romero", IsActive = true, HireDate = new DateTime(2018, 10, 28), Salary = 1_890_000 },
                new tblEmployees { FirstName = "Ángel", LastName = "Castaño", IsActive = false, HireDate = new DateTime(2013, 3, 15), Salary = 1_350_000 },
                new tblEmployees { FirstName = "Carolina", LastName = "Marulanda", IsActive = true, HireDate = new DateTime(2022, 5, 24), Salary = 1_920_000 },
                new tblEmployees { FirstName = "Tomás", LastName = "Arango", IsActive = true, HireDate = new DateTime(2019, 9, 9), Salary = 2_050_000 },
                new tblEmployees { FirstName = "Camilo", LastName = "Osorio", IsActive = false, HireDate = new DateTime(2016, 7, 1), Salary = 1_480_000 },
                new tblEmployees { FirstName = "Natalia", LastName = "Guzmán", IsActive = true, HireDate = new DateTime(2023, 6, 10), Salary = 1_970_000 });

        await _context.SaveChangesAsync();
    }
}