using Microsoft.EntityFrameworkCore;
using Phinscal.Models;
using System;

namespace Phinscal.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserModel GetUser(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public UserModel GetUser(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public UserModel Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password)!;
        }

        public bool IsUsernameValid(string username)
        {
            return !_context.Users.Any(u => u.Username == username);
        }
    }
}
