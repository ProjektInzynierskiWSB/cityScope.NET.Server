namespace cityScope.NET.Server.Application.Blob
{
    public class StorageAccountOptions
    {
        public string StorageAccountNameOption { get; set; } = string.Empty;
        public string StorageAccountKeyOption { get; set; } = string.Empty;
        public string FullImagesContainerNameOption { get; set; } = string.Empty;
        public string ScaledImagesContainerNameOption { get; set; } = string.Empty;
    }
}
