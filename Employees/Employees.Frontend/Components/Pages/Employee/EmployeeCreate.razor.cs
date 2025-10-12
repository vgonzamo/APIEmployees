using Employees.Frontend.Repositories;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Employees.Shared.Entities;


namespace Employees.Frontend.Components.Pages.Employee;

public partial class EmployeeCreate
{
    private tblEmployees Employee = new();

    [Inject] private IRepository Repository { get; set; } = null!;
    [Inject] private NavigationManager NavigationManager { get; set; } = null!;
    [Inject] private ISnackbar Snackbar { get; set; } = null!;

    private async Task CreateAsync()
    {
        var responseHttp = await Repository.PostAsync("api/Employess", Employee);
        if (responseHttp.Error)
        {
            var message = await responseHttp.GetErrorMessageAsync();
            Snackbar.Add(message!, Severity.Error);
            return;
        }

        Return();
        Snackbar.Add("Registro creado", Severity.Success);
    }

    private void Return()
    {
        NavigationManager.NavigateTo("employees");
    }
}