using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Application.Validators;
using cityScope.NET.Server.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IUserService _userService;
        public AnnouncementService(IAnnouncementRepository announcementRepository, IUserService userService)
        {
            _announcementRepository = announcementRepository;
            _userService = userService;
        }

        public async Task<BaseResponse<int>> AddAnnouncement(AnnouncementDto dto)
        {
            BaseResponse<int> response = new();
            int userId = _userService.GetUserId();
            AnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid)
            {
                Announcement announcement = new();
                announcement.Price = dto.Price;
                announcement.Description = dto.Description;
                announcement.Title = dto.Title;
                announcement.UserId = userId;
                var result = await _announcementRepository.AddAsync(announcement);
                response.Data = result.Id;
                response.Message = "Added succesfully";

                return response;
            }

            response.Data = 0;
            response.Success = false;
            response.Message = string.Join(", ", validadorResult.Errors);
            return response;                        
        }

        public async Task<BaseResponse<bool>> DeleteAnnouncement(int id)
        {
            BaseResponse<bool> response = new();
            int userId = _userService.GetUserId();
            var result = await _announcementRepository.GetByIdAsync(id);
            if (result.UserId != userId)
            {
                response.Success = false;
                response.Data = false;
                response.Message = "Not found";
                return response;
            }
            if (result != null)
            {
                await _announcementRepository.DeleteAsync(result);
                response.Data = true;
                response.Message = "Deleted succesfully";
                return response;
            }
            response.Data = false;
            response.Success = false;
            response.Message = "Not found";
            return response;
        }

        public async Task<BaseResponse<List<AnnouncementDto>>> GetAllAsync()
        {
            BaseResponse<List<AnnouncementDto>> response = new();
            List<AnnouncementDto> list = new();
            var result = await _announcementRepository.GetAllAsync();
            foreach (var item in result)
            {
                var dto = new AnnouncementDto();
                dto.Title = item.Title;
                dto.Description = item.Description;
                dto.Price = item.Price;
                dto.CreatedDate = item.CreatedDate;
                list.Add(dto);
            }
            response.Data = list;
            response.Success = true;

            return response;
        }

        public async Task<BaseResponse<AnnouncementDto>> GetAsyncId(int id)
        {
            BaseResponse<AnnouncementDto> response = new();
            var result = await _announcementRepository.GetByIdAsync(id);
            if (result == null)
            {
                response.Success = false;
                response.Message = "Not found";
                return response;
            }

            AnnouncementDto dto = new();
            dto.Title = result.Title;
            dto.Description = result.Description;
            dto.Price = result.Price;
            dto.CreatedDate = result.CreatedDate;
            dto.UserId = result.UserId;

            response.Data = dto;
            return response;
        }

        public async Task<BaseResponse<PagedAnnouncementsDto>> GetPagedAnnouncement(int page, int pageSize)
        {
            BaseResponse<PagedAnnouncementsDto> response = new();
            var result = await _announcementRepository.GetPagedAnnouncement(page, pageSize);
            if (result == null || result.Count == 0)
            {
                response.Data = new PagedAnnouncementsDto();
                response.Success = false;
                response.Message = "List was empty";
                return response;
            }
            var count = await _announcementRepository.GetTotalCountOfAnnouncements();

            PagedAnnouncementsDto paged = new();

            List<AnnouncementDto> dtoList = new();

            foreach (var item in result)
            {
                AnnouncementDto dto = new()
                {
                    Title = item.Title,
                    Description = item.Description,
                    Price = item.Price,
                    CreatedDate = item.CreatedDate,
                    UserId = item.UserId,
                };
                dtoList.Add(dto);
            }

            paged.Announcements = dtoList;
            paged.AllCount = count;
            paged.Page = page;
            paged.PageSize = pageSize;
            response.Data = paged;
            return response;
        }

        public async Task<BaseResponse<bool>> UpdateAnnouncement(AnnouncementDto dto, int id)
        {
            BaseResponse<bool> response = new();
            var result = await _announcementRepository.GetByIdAsync(id);
            if (result == null)
            {
                response.Success = false;
                response.Message = "Not found";
                return response;
            }

            int userId = _userService.GetUserId();
            AnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid && result.UserId == userId)
            {
                result.Price = dto.Price;
                result.Description = dto.Description;
                result.Title = dto.Title;
                await _announcementRepository.UpdateAsync(result);
                response.Data = true;
                response.Message = "Update succesfully";

                return response;
            }

            response.Data = false;
            response.Success = false;
            response.Message = string.Join(", ", validadorResult.Errors);
            return response;
        }
    }
}
