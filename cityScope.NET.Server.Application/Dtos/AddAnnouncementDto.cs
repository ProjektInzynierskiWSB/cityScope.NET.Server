using Microsoft.AspNetCore.Http;

namespace cityScope.NET.Server.Application.Dtos;

public class AddAnnouncementDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int? UserId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public IFormFile? Image { get; set; }
    public int MainCategoryId { get; set; }

}
