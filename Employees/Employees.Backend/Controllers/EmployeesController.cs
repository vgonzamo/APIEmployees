using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Dtos;
using Employees.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Backend.Controllers;

[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Route("api/[controller]")]
public class EmployeesController : GenericController<tblEmployees>

{
    private readonly IEmployeeUnitOfWork _EmployeesUnitOfWork;
    public EmployeesController(IGenericUnitOfWork<tblEmployees> baseUnit, IEmployeeUnitOfWork employeeUnit) : base(baseUnit)
    {
        _EmployeesUnitOfWork = employeeUnit;
    }

    [HttpGet("filter/{text}")]
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





