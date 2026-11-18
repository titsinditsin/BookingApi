using System.ComponentModel.DataAnnotations;
namespace BookingApi.Dtos
{
    public class RegisterDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string Password { get; set; } = null!;
        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string Name { get; set; } = null!;
    }
}