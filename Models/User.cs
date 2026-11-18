namespace BookingApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Name { get; set; } = null!;
        public UserRole Role { get; set; }
        public List<Service> Services { get; set; } = new();
        public List<Booking> Bookings { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
    }
}