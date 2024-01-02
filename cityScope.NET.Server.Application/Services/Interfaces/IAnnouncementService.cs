using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Services.Interfaces
{
    public interface IAnnouncementService
    {
        Task<BaseResponse<List<AnnouncementDto>>> GetAllAsync();
        Task<BaseResponse<AnnouncementDto>> GetAsyncId(int id);
        Task<BaseResponse<int>> AddAnnouncement(AddAnnouncementDto dto);
        Task<BaseResponse<bool>> DeleteAnnouncement(int id);
        Task<BaseResponse<bool>> UpdateAnnouncement(UpdateAnnouncementDto dto, int id);
        Task<BaseResponse<PagedAnnouncementsDto>> GetPagedAnnouncement(int page, int pageSize);
    }
}
