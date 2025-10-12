using Employees.backend.Data;
using Employees.backend.Repositories.Implementations;
using Employees.Backend.Helpers;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Dtos;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using Microsoft.EntityFrameworkCore;


namespace Employees.Backend.Repositories.Implementations
{
    public class EmployeesRepository : GenericRepository<tblEmployees>, IEmployeesRepository
    {

        private readonly DataContext _context;
        public EmployeesRepository(DataContext Context) : base(Context)
        {
            _context = Context;
        }

        public async Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(string text)
        {
            text = text.ToLower();

            var result = await _context.employees
                .Where(x => x.FirstName.ToLower().Contains(text) || x.LastName.ToLower().Contains(text))
                .ToListAsync();

            return new ActionResponse<IEnumerable<tblEmployees>>
            {
                WasSuccess = true,
                Result = result
            };
        }
        public override async Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(PaginationDTO pagination)
        {
            var queryable = _context.employees

                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.FirstName.ToLower().Contains(pagination.Filter.ToLower()) || x.LastName.ToLower().Contains(pagination.Filter.ToLower()));
            }

            return new ActionResponse<IEnumerable<tblEmployees>>
            {
                WasSuccess = true,
                Result = await queryable
                    .OrderBy(c => c.LastName)
                    .Paginate(pagination)
                    .ToListAsync()
            };
        }


        public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination)
        {
            var queryable = _context.employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.FirstName.ToLower().Contains(pagination.Filter.ToLower()) || x.LastName.ToLower().Contains(pagination.Filter.ToLower()));
            }

            double count = await queryable.CountAsync();
            return new ActionResponse<int>
            {
                WasSuccess = true,
                Result = (int)count
            };
        }

    }
}