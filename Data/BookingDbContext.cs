using BookingApi.Models;
using Microsoft.EntityFrameworkCore;
namespace BookingApi.Data
{
    public class BookingDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {

        }
        public DbSet<Booking> Bookings => Set<Booking>();
        public DbSet<Schedule> Schedules => Set<Schedule>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<User> Users => Set<User>();

    }
}