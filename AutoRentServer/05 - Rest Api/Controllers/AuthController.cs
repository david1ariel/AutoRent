using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeardMan
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("EntireWorld")]
    public class AuthController : ControllerBase
    {
        private readonly JwtHelper jwtHelper;
        private readonly UsersLogic logic;


        public AuthController(JwtHelper jwtHelper, UsersLogic logic)
        {
            this.jwtHelper = jwtHelper;
            this.logic = logic;
        }


        [HttpPost]
        [Route("register")]
        public IActionResult Register(UserModel user)
        {
            if (logic.isUserNameExists(user.Username))
                return BadRequest("user name allready exists");

            //logic.addUser(user);

            user.JwtToken = jwtHelper.GetWjtToken(user.Username);

            return Created("api/users/" + user.UserId, user);
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(CredentialsModel credentials)
        {
            UserModel user = logic.GetUsersByCredentials(credentials);

            if (user == null)
                return Unauthorized("incorrect username or password");

            user.JwtToken = jwtHelper.GetWjtToken(user.Username);

            return Ok(user);
        }
    }
}
