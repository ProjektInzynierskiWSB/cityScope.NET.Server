using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Persistence.Repository
{
    public class UserRepository : AsyncRepository<User>, IUserRepository
    {
        public UserRepository(MyDbContext context) : base(context)
        {
        }

        public async Task<bool> UserExist(string email)
        {
            return await _context.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()));
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));
        }
    }
}
