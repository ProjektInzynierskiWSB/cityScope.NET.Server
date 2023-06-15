using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool isBlocked { get; set; }
        public DateTime LastTimeLogin { get; set; }
    }
}
