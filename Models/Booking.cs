namespace BookingApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTimeOffset StartAt { get; set; }
        public DateTimeOffset EndAt { get; set; }
        public BookingStatus Status { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public User Client { get; set; } = null!;
        public Service Service { get; set; } = null!;

    }
}