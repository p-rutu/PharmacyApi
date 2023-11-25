using PharmacyUpdated.Models;
using PharmacyUpdated.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PharmacyUpdated.services
{
    public class UserService
    {
        private readonly UserRepo _user;
        public UserService(UserRepo user)
        {
            _user = user;
        }
        public  string CreateUser(User user)
        {
            return _user.CreateUser(user);
        }
        public string DeleteUserById(int id)
        {
            return _user.DeleteUserById(id);
        }
        public List<User> GetAllUser()
        {
            return _user.GetAllUser();
        }
        public User GetUserById(int id)
        {
            return  _user.GetUserById(id);
        }
        public string UpdateUser( User user)
        {
            return _user.UpdateUser( user);
        }
        public User GetIdByEmail(string email)
        {
            return _user.GetIdByEmail(email);
        }
    }
}
