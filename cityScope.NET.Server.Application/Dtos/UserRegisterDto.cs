namespace cityScope.NET.Server.Application.Dtos
{
    public class UserRegisterDto
    {
        public string Email { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
