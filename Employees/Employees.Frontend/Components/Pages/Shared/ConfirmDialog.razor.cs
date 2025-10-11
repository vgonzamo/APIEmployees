using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Employees.Frontend.Components.Pages.Shared;

public partial class ConfirmDialog
{
    [CascadingParameter] private IMudDialogInstance MudDialog { get; set; } = null!;
    [Parameter] public string Message { get; set; } = null!;

    private void Accept()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }

    private void Cancel()
    {
        MudDialog.Close(DialogResult.Cancel());
    }
}
