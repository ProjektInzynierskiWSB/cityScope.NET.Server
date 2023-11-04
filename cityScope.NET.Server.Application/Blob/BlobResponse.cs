namespace cityScope.NET.Server.Application.Blob;

public class BlobResponse
{
	public BlobResponse()
	{
		Blob = new BlobDto(); 
	}

	public string? Status { get; set; }
	public bool Error { get; set; }
	public BlobDto Blob { get; set; }
}
