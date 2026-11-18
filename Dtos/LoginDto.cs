using System.ComponentModel.DataAnnotations;
namespace BookingApi.Dtos
{
    public class LoginDto
    {
        [StringLength(100)]
        [Required]
        public string Password { get; set; } = null!;
        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;
    }
}