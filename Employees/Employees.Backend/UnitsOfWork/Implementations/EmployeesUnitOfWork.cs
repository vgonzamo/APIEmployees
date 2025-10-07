
using Orders.backend.UnitsOfWork.Implementations;
using Orders.Backend.Repositories.Interfaces;
using Orders.Shared.Entites;
using Orders.Shared.Entites.Responses;


namespace Employees.Backend.UnitsOfWork.Implementations
{
    public class EmployeesUnitOfWork : GenericUnitOfWork<Employee>, IEmployeeUnitOfWork
    {
        private readonly IEmployeeUnitOfWork _repository;

        public EmployeesUnitOfWork(IGenericRepository<Employee> repository, IEmployeeUnitOfWork employeesRepository) : base(repository)
        {
            _repository = employeesRepository;
        }

    
        public async Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text)
        {
            return await _repository.GetAsync(text);
        }
    }
}
