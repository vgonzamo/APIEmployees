using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Shared.Dtos;

public class TokenDTOS
{
    public string Token { get; set; } = null!;

    public DateTime Expiration { get; set; }
}
