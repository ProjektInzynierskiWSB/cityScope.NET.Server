using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Application.Dtos
{
    public class AnnouncementDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; } 
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;
    }
}
