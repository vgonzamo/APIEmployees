
using Orders.Shared.Entites;
using Orders.Shared.Entites.Responses;


public interface IEmployeeUnitOfWork
{
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text);
}