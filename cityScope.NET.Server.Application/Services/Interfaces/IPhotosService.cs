using cityScope.NET.Server.Application.Blob;
using Microsoft.AspNetCore.Http;

namespace cityScope.NET.Server.Application.Services.Interfaces
{
    public interface IPhotosService
    {
        Task<BlobResponse> UploadImage(IFormFile blob);
    }
}
