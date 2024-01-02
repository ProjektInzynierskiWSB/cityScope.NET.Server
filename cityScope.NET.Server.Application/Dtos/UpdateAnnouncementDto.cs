using Microsoft.AspNetCore.Http;

namespace cityScope.NET.Server.Application.Dtos
{
    public class UpdateAnnouncementDto
    {
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public IFormFile? Image { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
