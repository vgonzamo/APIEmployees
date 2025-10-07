﻿using Orders.Shared.Entites;
using Orders.Shared.Entites.Responses;


namespace Orders.Backend.UnitsOfWork.Interfaces;

public interface IGenericUnitOfWork<T> where T : class
{
    Task<ActionResponse<IEnumerable<T>>> GetAsync();

    Task<ActionResponse<T>> AddAsync(T model);

    Task<ActionResponse<T>> UpdateAsync(T model);

    Task<ActionResponse<T>> DeleteAsync(int id);

    Task<ActionResponse<T>> GetAsync(int id);
    Task<ActionResponse<IEnumerable<Employee>>> GetAsync(string text);
   
}
