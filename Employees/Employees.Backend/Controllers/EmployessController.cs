using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Dtos;
using Employeess.backend.Controllers;
using Employeess.Backend.UnitsOfWork.Implementations;
using Employeess.Shared.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Backend.Controllers;

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

    [HttpGet("paginated")]
    public override async Task<IActionResult> GetAsync([FromQuery] PaginationDTO pagination)
    {
        var response = await _EmployeesUnitOfWork.GetAsync(pagination);
        if (response.WasSuccess)
        {
            return Ok(response.Result);
        }
        return BadRequest();
    }

    [HttpGet("totalRecords")]
    public override async Task<IActionResult> GetTotalRecordsAsync([FromQuery] PaginationDTO pagination)
    {
        var action = await _EmployeesUnitOfWork.GetTotalRecordsAsync(pagination);
        if (action.WasSuccess)
        {
            return Ok(action.Result);
        }
        return BadRequest();
    }
}





