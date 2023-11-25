using Microsoft.EntityFrameworkCore;
using PharmacyUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PharmacyUpdated.Repository
{
    public class UserRepo : Iuser
    {
        private readonly PharmacyProjectContext _context;
        public UserRepo(PharmacyProjectContext context)
        {
            _context = context;
        }

        #region CreateUser
        public String CreateUser(User user)
        {
            string stcode=string.Empty;
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                stcode = "200";
            }
            catch (Exception)
            {
                stcode = "400";
            }
            

            return stcode;
        }
        #endregion

        #region  DeleteUserById
        public string  DeleteUserById(int id)
        {
            string Result = string.Empty;
            User user = null;
            try
            {
                user= _context.Users.Find(id);
                
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    Result = "200";
                }

                
            }
            catch (Exception)
            {
                Result = "400";
            }

            return Result;
        }
        #endregion

        #region GetAllUser
        public List<User> GetAllUser()
        {
            List<User> users = null;
            try
            {
                users= _context.Users.ToList();
            }
            catch (Exception)
            {

            }
            return users;
        }
        #endregion

        #region GetUserById
        public  User GetUserById(int id)
        {
            User result = null;
            try
            {

                result= _context.Users.FirstOrDefault(User => User.UserId == id);
            }
            catch(Exception)
            {

            }
            return result;
        }
        #endregion



        #region UpdateUser
        public string UpdateUser( User user)
        {
            string Result=string.Empty;
            try
            {
                _context.Entry(user).State=EntityState.Modified;
                _context.SaveChanges();
                Result = "200";
            }
            catch (Exception e){
                Result = "400";
            }

            return Result;
        }
        #endregion

        public User GetIdByEmail(string email)
        {
            User result = null;
            try
            {

                result = _context.Users.FirstOrDefault(User => User.UserEmail == email);
            }
            catch (Exception)
            {
                result=null;
            }
            return result;
        }
    }
}
