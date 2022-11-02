using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentalCar.Model.Models;

namespace RentalCar.Data.Repositories
{
    public interface IUserReposity
    {
        IEnumerable<User> GetUsers();

        User GetUserById(int id);

        User GetUserByUsername(string username);

        IEnumerable<User> GetUsersByRole(int roleId);
    }
}