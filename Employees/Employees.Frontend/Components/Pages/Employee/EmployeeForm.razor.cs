using Employees.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Employees.Frontend.Components.Pages.Employee;

public partial class EmployeeForm
{
    private EditContext editContext = null!;

    [EditorRequired, Parameter] public tblEmployees employee { get; set; } = null!;
    [EditorRequired, Parameter] public EventCallback OnValidSubmit { get; set; }
    [EditorRequired, Parameter] public EventCallback ReturnAction { get; set; }

    protected override void OnInitialized()
    {
        editContext = new(employee);
    }
}
