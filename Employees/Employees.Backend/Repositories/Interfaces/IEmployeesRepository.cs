using Employees.Shared.Dtos;
using Employees.Shared.Entities;
using Employees.Shared.Responses;

namespace Employees.Backend.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(string text);
        Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);


    }

}