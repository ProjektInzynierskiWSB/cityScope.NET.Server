using cityScope.NET.Server.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Interfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<bool> UserExist(string email);
        Task<User> GetUserByEmail(string email);
    }
}
