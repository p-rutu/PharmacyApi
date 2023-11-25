using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PharmacyUpdated.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace PharmacyUpdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _login;
        private readonly PharmacyProjectContext _context;
        public LoginController(IConfiguration config, PharmacyProjectContext context)
        {
            _login = config;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] Login login)
        {


            if (login.Role == "Admin")
            {
                var CurrentUser = AdminConstants._admin.FirstOrDefault(
                c => c.emailId.ToLower() == login.EmailID.ToLower()
                && c.password == login.Password);
                if (CurrentUser != null)
                {
                    var token = Generate(CurrentUser);
                    return Ok(token);
                }
            }
            else if (login.Role == "Doctor")
            {
                var Doctor = _context.Users.FirstOrDefault(
                             c => c.UserEmail.ToLower() == login.EmailID.ToLower()
                             && c.UserPassword == login.Password);
                if (Doctor != null)
                {

                    var token = GenerateDoctor(Doctor);
                    return Ok(token);
                }

            }
            return BadRequest("User Not Found");
        }

        private string Generate(Admin user)
        {


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Email",user.emailId.ToString())

                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;



        }


        private string GenerateDoctor(User user)
        {


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Email",user.UserEmail.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;



        }




       
        
    }
}
