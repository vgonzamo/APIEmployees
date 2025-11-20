using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Dtos;
using Microsoft.AspNetCore.Identity;
using Employees.Shared.Entities;
using Employees.Backend.Repositories.Interfaces;


namespace Employees.Backend.UnitsOfWork.Implementations;

public class UsersUnitOfWork : IUsersUnitOfWork
{
    private readonly IUsersRepository _usersRepository;

    public UsersUnitOfWork(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<SignInResult> LoginAsync(LoginDTOS model) => await _usersRepository.LoginAsync(model);

    public async Task LogoutAsync() => await _usersRepository.LogoutAsync();

    public async Task<IdentityResult> AddUserAsync(User user, string password) => await _usersRepository.AddUserAsync(user, password);

    public async Task AddUserToRoleAsync(User user, string roleName) => await _usersRepository.AddUserToRoleAsync(user, roleName);

    public async Task CheckRoleAsync(string roleName) => await _usersRepository.CheckRoleAsync(roleName);

    public async Task<User> GetUserAsync(string email) => await _usersRepository.GetUserAsync(email);

    public async Task<bool> IsUserInRoleAsync(User user, string roleName) => await _usersRepository.IsUserInRoleAsync(user, roleName);

    public async Task<User> GetUserAsync(Guid userId) => await _usersRepository.GetUserAsync(userId);

    public async Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword) => await _usersRepository.ChangePasswordAsync(user, currentPassword, newPassword);

    public async Task<IdentityResult> UpdateUserAsync(User user) => await _usersRepository.UpdateUserAsync(user);

}
