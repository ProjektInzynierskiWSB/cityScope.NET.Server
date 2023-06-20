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
    public class AnnouncementRepository : AsyncRepository<Announcement>, IAnnouncementRepository
    {
        public AnnouncementRepository(MyDbContext context) : base(context)
        {
        }

        public async Task<List<Announcement>> GetPagedAnnouncement(int page, int pageSize)
        {
            return await _context.Announcements.Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
        }

        public async Task<int> GetTotalCountOfAnnouncements()
        {
            return await _context.Announcements.CountAsync();
        }
    }
}
