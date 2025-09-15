using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using DocuSign.eSign.Model;

namespace Orders.Shared.Entites;
    public class Employee
{

    public int Id { get; set; }
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
    public string FristName { get; set; } = null!;
    [MaxLength(30, ErrorMessage= "El campo {0} no puede  tener mas de {1} caracteres")]
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set; }

    public DateTime HireDate { get; set; }

    [Range(1000000, double.MaxValue)]
    public decimal Salary { get; set; }



}

