namespace BookingApi.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public string Title { get; set; } = null!;
        public int DurationMin { get; set; }
        public decimal Price { get; set; }
        public User Master { get; set; } = null!;
        public List<Booking> Bookings { get; set; } = new();
    }
}