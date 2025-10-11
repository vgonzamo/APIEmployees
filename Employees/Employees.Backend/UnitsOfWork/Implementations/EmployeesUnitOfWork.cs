using DocuSign.eSign.Model;
using Employees.backend.UnitsOfWork.Implementations;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Dtos;
using Employees.Shared.Entites.Responses;
using Employeess.backend.Data;
using Employeess.Backend.Repositories.Implementations;
using Employeess.Backend.Repositories.Interfaces;
using Employeess.Shared.Entites;
using Microsoft.EntityFrameworkCore;


namespace Employeess.Backend.UnitsOfWork.Implementations
{
    public class EmployeesUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesUnitOfWork(IGenericRepository<Employee> repository, IEmployeesRepository employeesRepository) : base(repository)
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text)
        {
            return await _employeesRepository.GetAsync(text);
        }

        public override async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination) => await _employeesRepository.GetAsync(pagination);

        public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _employeesRepository.GetTotalRecordsAsync(pagination);

    }
}

