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
    }
}
