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
    public class RentsController : ControllerBase
    {
        private readonly RentsLogic rentsLogic;

        public RentsController(RentsLogic rentsLogic)
        {
            this.rentsLogic = rentsLogic;
        }



        [HttpGet]
        public IActionResult GetAllRents()
        {
            try
            {
                return Ok(rentsLogic.GetAllRents());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            rentsLogic.Dispose();
        }
    }
}
