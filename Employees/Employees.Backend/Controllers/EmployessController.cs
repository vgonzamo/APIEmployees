using DocuSign.eSign.Model;
using Employees.Backend.UnitsOfWork.Implementations;
using Microsoft.AspNetCore.Mvc;
using Orders.backend.Controllers;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entites;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployessController : GenericController<Employee>

{
    private readonly IEmployeeUnitOfWork _EmployeesUnitOfWork;
    public EmployessController(IGenericUnitOfWork<Employee> baseUnit, IEmployeeUnitOfWork employeeUnit) : base(baseUnit)
    {
        _EmployeesUnitOfWork = employeeUnit;
    }

    [HttpGet("search/{text}")]
    public async Task<IActionResult> SearchAsync(string text)
    {
        var action = await _EmployeesUnitOfWork.GetAsync(text);
        if (action.WasSuccess)
            return Ok(action.Result);

        return NotFound();
    }
}
