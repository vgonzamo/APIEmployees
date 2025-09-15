
using Employees.Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Orders.backend.Data;
using Orders.backend.Repositories.Implementations;
using Orders.Shared.Entites;
using Orders.Shared.Entites.Responses;


namespace Employees.Backend.Repositories.Implementations
{
    public class EmployeesRepository : GenericRepository<Employee>, IEmployeesRepository
    {

        private readonly DataContext _context;
        public EmployeesRepository(DataContext Context) : base(Context)
        {
            _context = Context;
        }

        public async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text)
        {
            text = text.ToLower();

            var result = await _context.employees
                .Where(x => x.FristName.ToLower().Contains(text) || x.LastName.ToLower().Contains(text))
                .ToListAsync();

            return new ActionResponse<IEnumerable<Employee>>
            {
                WasSuccess = true,
                Result = result
            };
        }


    }
}