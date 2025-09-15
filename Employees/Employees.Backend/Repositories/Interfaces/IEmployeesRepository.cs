
using Orders.Shared.Entites;
using Orders.Shared.Entites.Responses;

namespace Employees.Backend.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text);
    }
}