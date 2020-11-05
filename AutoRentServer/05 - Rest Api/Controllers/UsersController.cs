using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeardMan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors]
    public class UsersController : ControllerBase
    {
        private readonly UsersLogic usersLogic;

        public UsersController(UsersLogic usersLogic)
        {
            this.usersLogic = usersLogic;
        }



        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(usersLogic.GetAllUsers());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            usersLogic.Dispose();
        }
    }
}
