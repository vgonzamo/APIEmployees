using Employees.Backend.Helpers;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Dtos;
using Employees.Shared.Entites.Responses;
using Employeess.backend.Data;
using Microsoft.EntityFrameworkCore;

namespace Employees.backend.Repositories.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DataContext _context;
    private readonly DbSet<T> _entity;

    public GenericRepository(DataContext context)
    {
        _context = context;
        _entity = _context.Set<T>();
    }
    public virtual async Task<ActionResponse<T>> AddAsync(T entity)
    {
        _context.Add(entity);
        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {

                WasSuccess = true,
                Result = entity
            };
        }
        catch (DbUpdateException)
        {
            return DbUpdateExceptionActionResponse();
        }
        catch (Exception exception)
        {

            return ExceptionActionResponse(exception);

        }
    }


    public virtual async Task<ActionResponse<T>> DeleteAsync(int id)
    {
        var row = await _entity.FindAsync(id);
        if (row == null)
        {
            return new ActionResponse<T>
            {
                Message = "Registro no encontrado"
            };
        }
        _entity.Remove(row);

        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {
                WasSuccess = true
            };
        }
        catch
        {
            return new ActionResponse<T>
            {
                Message = "No se puede borrar porque tiene registros relacionados."
            };
        }
    }

    public virtual async Task<ActionResponse<T>> GetAsync(int id)
    {

        var row = await _entity.FindAsync(id);
        if (row == null)
        {
            return new ActionResponse<T>
            {
                Message = "Registro no encontrado"
            };
        }
        return new ActionResponse<T>
        {
            WasSuccess = true,
            Result = row
        };
    }


    public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync() => new ActionResponse<IEnumerable<T>>
    {
        WasSuccess = true,
        Result = await _entity.ToListAsync()

    };


    public virtual async Task<ActionResponse<T>> UpdateAsync(T entity)
    {
        _context.Update(entity);
        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {

                WasSuccess = true,
                Result = entity
            };
        }
        catch (DbUpdateException)
        {
            return DbUpdateExceptionActionResponse();
        }
        catch (Exception exception)
        {

            return ExceptionActionResponse(exception);

        }
    }

    private ActionResponse<T> ExceptionActionResponse(Exception exception) =>
    new ActionResponse<T>
    {
        Message = exception.Message
    };


    private ActionResponse<T> DbUpdateExceptionActionResponse() =>
    new ActionResponse<T>
    {
        Message = "El  registro ya existe"
    };

    public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync(PaginationDTO pagination)
    {
        var queryable = _entity.AsQueryable();

        return new ActionResponse<IEnumerable<T>>
        {
            WasSuccess = true,
            Result = await queryable
                .Paginate(pagination)
                .ToListAsync()
        };
    }

    public virtual async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination)
    {
        var queryable = _entity.AsQueryable();
        double count = await queryable.CountAsync();
        return new ActionResponse<int>
        {
            WasSuccess = true,
            Result = (int)count
        };
    }

}
