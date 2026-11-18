namespace BookingApi.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public User Master { get; set; } = null!;
    }
}