using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cityScope.NET.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IWebHostEnvironment _environment;

        public AnnouncementController(IAnnouncementService announcementService, IWebHostEnvironment environment)
        {
            _announcementService = announcementService;
            _environment = environment;
        }

        [HttpGet(Name = "GetAllAnnouncements")]
        [Authorize]
        public async Task<ActionResult<BaseResponse<List<AnnouncementDto>>>> GetAllAnnouncements()
        {
            var result = await _announcementService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("/GetPagedAnnouncements", Name = "GetPagedAnnouncements")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BaseResponse<PagedAnnouncementsDto>>> GetPagedAnnouncements(int page, int pageSize)
        {
            var result = await _announcementService.GetPagedAnnouncement(page, pageSize);
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BaseResponse<AnnouncementDto>>> GetAnnouncementById([FromRoute] int id)
        {
            var result = await _announcementService.GetAsyncId(id);
            if (result.Success == false)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        [Authorize]
        public async Task<ActionResult<BaseResponse<int>>> AddAnnouncement([FromForm] AddAnnouncementDto announcement)
        {
            var result = await _announcementService.AddAnnouncement(announcement);
            if (result.Success == false) 
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{id}", Name = "Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [Authorize]
        public async Task<ActionResult<bool>> UpdateAnnouncement([FromBody] AddAnnouncementDto announcement, [FromRoute] int id)
        {
            var result = await _announcementService.UpdateAnnouncement(announcement, id);
            if (result.Success == false) 
            {
                return NotFound();
            }
            return Ok(result);
        }

        //in future change for soft delete 
        [HttpDelete("{id}", Name ="Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [Authorize]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _announcementService.DeleteAnnouncement(id);
            if (result.Success == false)
            {
                return NotFound();
            }
            return Ok(result); 
        }

        [NonAction]
        private async Task<bool> SaveImages(List<IFormFile> images, int announcementId)
        {
            bool success = false;
            try
            {
                foreach (IFormFile item in images)
                {
                    string fileName = item.FileName;
                    string filePath = GetFilePath(fileName, announcementId);

                    if (!System.IO.Directory.Exists(filePath))
                    {
                        System.IO.Directory.CreateDirectory(filePath);
                    }

                    string imagePath = filePath + announcementId.ToString() + "\\image.png";

                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }

                    await using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        await item.OpenReadStream().CopyToAsync(stream);
                    }
                }

                success = true;
            }
            catch (Exception ex)
            {

            }

            return success;
        }

        [NonAction]
        private string GetFilePath(string fileName, int announcementId)
        {
            return _environment.WebRootPath + "\\Uploads\\Announcement\\" + announcementId + "\\" + fileName;
        }

    }
}
