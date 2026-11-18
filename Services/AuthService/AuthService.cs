using System.ComponentModel.DataAnnotations;
using BookingApi.Data;
using BookingApi.Dtos;
using BookingApi.Exceptions;
using BookingApi.Models;
using Microsoft.EntityFrameworkCore;
namespace BookingApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly BookingDbContext _context;
        public AuthService(BookingDbContext context)
        {
            _context = context;
        }
        public async Task<UserDto> RegisterAsync(RegisterDto regData)
        {
            if(await _context.Users.AnyAsync(e => e.Email == regData.Email.ToLower()))
            {
                throw new EmailInUseException();
            }

            var user = new User {
                Email = regData.Email.ToLower(),
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(regData.Password),
                Name = regData.Name,
                Role = UserRole.Client
            };
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new EmailInUseException();
            }
            return new UserDto
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Role = user.Role
            };
        }

        public async Task<LoginResultDto> LoginAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}