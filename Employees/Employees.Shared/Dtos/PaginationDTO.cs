﻿namespace Employees.Shared.Dtos;

public class PaginationDTO
{


    public int Page { get; set; } = 1;

    public int RecordsNumber { get; set; } = 10;
    public string? Filter { get; set; }
}
