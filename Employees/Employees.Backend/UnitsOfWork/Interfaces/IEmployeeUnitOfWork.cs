using Employees.Shared.Dtos;
using Employees.Shared.Entities;
using Employees.Shared.Responses;

namespace Employees.Backend.UnitsOfWork.Interfaces;
public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(string text);
    Task<ActionResponse<IEnumerable<tblEmployees>>> GetAsync(PaginationDTO pagination);
    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);

}