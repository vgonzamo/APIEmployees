using DocuSign.eSign.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.backend.Data;
using Orders.backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entites;

namespace Orders.backend.Controllers;

[ApiController]
[Route("api/ [Controller]")]

public class EmployeesController : GenericController<Employee>
{
    public EmployeesController(IGenericUnitOfWork<Employee> unitOfWork) : base(unitOfWork)
    {
    }
}