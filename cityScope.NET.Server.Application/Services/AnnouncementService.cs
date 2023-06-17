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
        public AnnouncementService(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public async Task<BaseResponse<int>> AddAnnouncement(AnnouncementDto dto)
        {
            BaseResponse<int> response = new();
            AnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid)
            {
                Announcement announcement = new();
                announcement.Price = dto.Price;
                announcement.Description = dto.Description;
                announcement.Title = dto.Title;
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
            var result = await _announcementRepository.GetByIdAsync(id);
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

            response.Data = dto;
            return response;
        }

        public async Task<BaseResponse<bool>> UpdateAnnouncement(AnnouncementDto dto, int id)
        {
            BaseResponse<bool> response = new();
            AnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid)
            {
                Announcement announcement = new();
                announcement.Price = dto.Price;
                announcement.Description = dto.Description;
                announcement.Title = dto.Title;
                await _announcementRepository.UpdateAsync(announcement);
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
