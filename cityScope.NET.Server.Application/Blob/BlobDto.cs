namespace cityScope.NET.Server.Application.Blob;

public class BlobDto
{
    public string? Uri { get; set; }
    public string? Name { get; set; }
    public string? ContentType { get; set; }
    public Stream? Contnet { get; set; }
}
