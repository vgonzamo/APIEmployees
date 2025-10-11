using DocuSign.eSign.Model;
using Employees.Shared.Dtos;
using Employees.Shared.Entites.Responses;
using Employeess.Shared.Entites;

namespace Employeess.Backend.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text);
        Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);


    }

}