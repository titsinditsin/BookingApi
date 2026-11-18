using BookingApi.Models;
namespace BookingApi.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public UserRole Role { get; set; }
    }
}