namespace BookingApi.Dtos
{
    public class LoginResultDto
    {
        public UserDto User { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}