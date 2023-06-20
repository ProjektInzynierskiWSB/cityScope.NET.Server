using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Dtos
{
    public class PagedAnnouncementsDto
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public int AllCount { get; set; }
        public List<AnnouncementDto> Announcements { get; set; } = new List<AnnouncementDto>();
    }
}
