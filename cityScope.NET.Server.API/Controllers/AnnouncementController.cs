using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cityScope.NET.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public AnnouncementController(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        [HttpGet(Name = "GetAllAnnouncements")]
        public async Task<IReadOnlyList<Announcement>> GetAllAnnouncements()
        {
            return await _announcementRepository.GetAllAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Announcement>> GetAnnouncementById(int id)
        {
            var result = await _announcementRepository.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddAnnouncement([FromBody] Announcement announcement)
        {
            var result = await _announcementRepository.AddAsync(announcement);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateAnnouncement([FromBody] Announcement announcement)
        {
            await _announcementRepository.UpdateAsync(announcement);
            return Ok();
        }

        [HttpDelete("{id}", Name ="Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _announcementRepository.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }                    
            await _announcementRepository.DeleteAsync(result);
            return NoContent(); 
        }
    }
}
