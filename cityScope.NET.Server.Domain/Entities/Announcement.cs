namespace cityScope.NET.Server.Domain.Entities
{
    public class Announcement : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string? UrlImage { get; set; }
    }
}
