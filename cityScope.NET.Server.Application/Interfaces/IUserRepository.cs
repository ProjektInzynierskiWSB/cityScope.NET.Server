using cityScope.NET.Server.Domain.Entities;

namespace cityScope.NET.Server.Application.Interfaces;

public interface IUserRepository : IAsyncRepository<User>
{
    Task<bool> UserExist(string email);
    Task<User> GetUserByEmail(string email);
}
