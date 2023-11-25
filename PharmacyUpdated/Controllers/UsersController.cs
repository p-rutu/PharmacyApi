using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyUpdated.Models;
using PharmacyUpdated.services;

namespace PharmacyUpdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly PharmacyProjectContext _context;
        private readonly UserService _user;

        public UsersController(UserService user, PharmacyProjectContext context)
        {
            _user = user;
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public List<User> GetUsers()
        {
            return _user.GetAllUser();
        }
        [HttpGet("GetUserByEmail")]
        public IActionResult GetUserByEmail(string email)
        {
            return Ok(_user.GetIdByEmail(email));
        }


        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(_user.GetUserById(id));
        }

        // PUT: api/User/5

        [HttpPut]
        public  IActionResult PutUser(User user)
        {
           return Ok(_user.UpdateUser(user));
        }


        [HttpPost]
        public IActionResult PostUser(User user)
        {
            return Ok(_user.CreateUser(user));
        }




        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            
            

            return Ok(_user.DeleteUserById(id));
        }
    }
}
