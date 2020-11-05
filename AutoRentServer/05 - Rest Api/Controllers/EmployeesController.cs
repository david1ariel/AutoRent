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
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesLogic employeesLogic;

        public EmployeesController(EmployeesLogic employeesLogic)
        {
            this.employeesLogic = employeesLogic;
        }



        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                return Ok(employeesLogic.GetAllEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            employeesLogic.Dispose();
        }
    }
}
