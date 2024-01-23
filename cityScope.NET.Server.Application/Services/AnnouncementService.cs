using cityScope.NET.Server.Application.Blob;
using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Application.Validators;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace cityScope.NET.Server.Application.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IUserService _userService;
        private readonly IPhotosService _photosService;
        private readonly IMainCategoryService _mainCategoryService;

        public AnnouncementService(IAnnouncementRepository announcementRepository, 
            IUserService userService, 
            IPhotosService photosService,
            IMainCategoryService mainCategoryService)
        {
            _announcementRepository = announcementRepository;
            _userService = userService;
            _photosService = photosService;
            _mainCategoryService = mainCategoryService;
        }

        public async Task<BaseResponse<int>> AddAnnouncement(AddAnnouncementDto dto)
        {
            BaseResponse<int> response = new();
            int userId = _userService.GetUserId();
            var categoryExist = await _mainCategoryService.IsIdExist(dto.MainCategoryId);
            AnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid && categoryExist.Data)
            {
                Announcement announcement = new();
                if (dto.Image != null)
                {
                    var blobResponse = await _photosService.UploadImage(dto.Image);
                    announcement.UrlImage = blobResponse.Blob.Uri;
                }
                announcement.Price = dto.Price;
                announcement.Description = dto.Description;
                announcement.Title = dto.Title;
                announcement.UserId = userId;
                announcement.MainCategoryId = dto.MainCategoryId;

                var result = await _announcementRepository.AddAsync(announcement);
                response.Data = result.Id;
                response.Message = "Added succesfully";

                return response;
            }
            response.Data = 0;
            response.Success = false;
            response.Message = string.Join(", ", validadorResult.Errors);
            response.Message = string.Join(", ", categoryExist.Message);
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
                dto.ImageUrl = item.UrlImage;
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
            dto.Id = result.Id;
            dto.Title = result.Title;
            dto.Description = result.Description;
            dto.Price = result.Price;
            dto.CreatedDate = result.CreatedDate;
            dto.UserId = result.UserId;
            dto.ImageUrl = result.UrlImage;
            dto.CategoryId = result.MainCategoryId;

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
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Price = item.Price,
                    CreatedDate = item.CreatedDate,
                    UserId = item.UserId,
                    ImageUrl = item.UrlImage
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

        public async Task<BaseResponse<bool>> UpdateAnnouncement(UpdateAnnouncementDto dto, int id)
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
            UpdateAnnouncementValidator validator = new();
            var validadorResult = await validator.ValidateAsync(dto);
            if (validadorResult.IsValid && result.UserId == userId)
            {
                if (dto.Image != null)
                {
                    var blobResponse = await _photosService.UploadImage(dto.Image);
                    result.UrlImage = blobResponse.Blob.Uri;
                }
                result.Price = dto.Price.HasValue ? dto.Price.Value : result.Price;
                result.Description = !string.IsNullOrEmpty(dto.Description) ? dto.Description : result.Description;
                result.Title = !string.IsNullOrEmpty(dto.Title) ? dto.Title : result.Title;
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
