using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Sas;
using cityScope.NET.Server.Application.Blob;
using cityScope.NET.Server.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Web;

namespace cityScope.NET.Server.Application.Services
{
    public class PhotosService : IPhotosService
    {
        private readonly IOptions<StorageAccountOptions> _options;
        private readonly BlobContainerClient _filesContainer;

        public PhotosService(IOptions<StorageAccountOptions> options)
        {
            _options = options;
            var credential = new StorageSharedKeyCredential(_options.Value.StorageAccountNameOption, _options.Value.StorageAccountKeyOption);
            var blobUri = $"https://{_options.Value.StorageAccountNameOption}.blob.core.windows.net";
            var blobServiceClient = new BlobServiceClient(new Uri(blobUri), credential);
            _filesContainer = blobServiceClient.GetBlobContainerClient(_options.Value.FullImagesContainerNameOption);
        }

        public async Task<BlobResponse> UploadImage(IFormFile blob)
        {
            BlobResponse blobResponse = new();
            var blobName = Guid.NewGuid().ToString();
            var blobHttpHeader = new BlobHttpHeaders
            {
                ContentType = "image/png"
            };
            BlobClient client = _filesContainer.GetBlobClient(blobName);

            await using (Stream? data = blob.OpenReadStream())
                await client.UploadAsync(data, blobHttpHeader);

            blobResponse.Status = $"File {blob.FileName} Upload successfully";
            blobResponse.Error = false;
            blobResponse.Blob.Uri = client.Uri.AbsoluteUri;
            blobResponse.Blob.Name = client.Name;

            return blobResponse;
        }
    }
}
