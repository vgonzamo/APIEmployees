using Employees.Backend.UnitsOfWork.Implementations;
using Employees.Backend.Repositories.Interfaces;
using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Dtos;
using Employees.Shared.Entities;
using Employees.Shared.Responses;

namespace Employees.Backend.UnitsOfWork.Implementations
{
    public class EmployeesUnitOfWork : GenericUnitOfWork<tblEmployees>, IEmployeeUnitOfWork
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesUnitOfWork(IGenericRepository<tblEmployees> repository, IEmployeesRepository employeesRepository) : base(repository)
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(string text)
        {
            return await _employeesRepository.GetAsync(text);
        }

        public override async Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(PaginationDTO pagination) => await _employeesRepository.GetAsync(pagination);

        public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _employeesRepository.GetTotalRecordsAsync(pagination);

    }
}

