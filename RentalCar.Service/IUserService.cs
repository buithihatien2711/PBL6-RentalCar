using RentalCar.Model.Models;

namespace RentalCar.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();

        User GetUserById(int id);

        User GetUserByUsername(string username);
    }
}