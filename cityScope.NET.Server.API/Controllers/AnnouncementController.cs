﻿using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using cityScope.NET.Server.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cityScope.NET.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet(Name = "GetAllAnnouncements")]
        public async Task<ActionResult<BaseResponse<List<AnnouncementDto>>>> GetAllAnnouncements()
        {
            var result = await _announcementService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<BaseResponse<AnnouncementDto>>> GetAnnouncementById(int id)
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
        public async Task<ActionResult<BaseResponse<int>>> AddAnnouncement([FromBody] AnnouncementDto announcement)
        {
            var result = await _announcementService.AddAnnouncement(announcement);
            if (result.Success == false) 
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<bool>> UpdateAnnouncement([FromBody] AnnouncementDto announcement, [FromRoute] int id)
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
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _announcementService.DeleteAnnouncement(id);
            if (result.Success == false)
            {
                return NotFound();
            }
            return Ok(result); 
        }
    }
}
