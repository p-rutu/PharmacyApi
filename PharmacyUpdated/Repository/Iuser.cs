using PharmacyUpdated.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmacyUpdated.Repository
{
    public interface Iuser
    {
        public List<User> GetAllUser();
        public User GetUserById(int id);
        public string UpdateUser(User user);
        public string CreateUser(User user);
        public string DeleteUserById(int id);

        public User GetIdByEmail(string email);
    }
}
