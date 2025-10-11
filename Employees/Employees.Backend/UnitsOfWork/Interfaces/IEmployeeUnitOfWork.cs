using DocuSign.eSign.Model;
using Employees.Shared.Dtos;
using Employees.Shared.Entites.Responses;
using Employeess.Shared.Entites;


public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text);
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(PaginationDTO pagination);
    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);

}