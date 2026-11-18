using BookingApi.Dtos;
namespace BookingApi.Services
{
    public interface IAuthService
    {
        public Task<UserDto> RegisterAsync(RegisterDto regData);

        public Task<LoginResultDto> LoginAsync(LoginDto dto);
    }
}