using DocuSign.eSign.Model;
using Microsoft.AspNetCore.Mvc;
using Orders.backend.Controllers;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entites;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployessController : GenericController<Employee>
{
    public EmployessController(IGenericUnitOfWork<Employee> unit) : base(unit)
    {
    }
}
