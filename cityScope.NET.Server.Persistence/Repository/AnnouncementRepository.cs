using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Domain.Entities;
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
    }
}
