using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentalCar.Model.Models;

namespace RentalCar.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<Role> GetRolesOfUser(string username)
        {
            var user = GetUserByUsername(username);
            if (user == null) return null;
            List<RoleUser> roleUsers = _context.RoleUsers.Include(ru => ru.User).Include(ru => ru.Role)
                                        .Where(u => u.UserId == user.Id).ToList();

            List<Role> roles = new List<Role>();
            foreach (var roleUser in roleUsers)
            {
                var id = roleUser.RoleId;
                var name = roleUser.Role.Name;

                var role = new Role()
                {
                    Id = id,
                    Name = name
                };
                roles.Add(role);
            }
            return roles;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}