using cityScope.NET.Server.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Interfaces
{
    public interface IAnnouncementRepository : IAsyncRepository<Announcement>
    {
        Task<List<Announcement>> GetPagedAnnouncement(int page, int pageSize);
        Task<int> GetTotalCountOfAnnouncements();
        Task<Announcement> GetAnnouncementAsyncById(int id);
    }
}
