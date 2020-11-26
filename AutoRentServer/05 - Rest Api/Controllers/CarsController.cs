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
    public class CarsController : ControllerBase
    {
        private readonly CarsLogic carsLogic;

        public CarsController(CarsLogic carsLogic)
        {
            this.carsLogic = carsLogic;
        }



        [HttpGet]
        [Route("available")]
        public IActionResult GetAllCars()
        {
            try
            {
                List<CarModel> allCars = carsLogic.GetAllCars();
                return Ok(allCars.Select(p => carsLogic.ConstructAvaialbleCarModel(new CarModel(p))).ToList(););
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            carsLogic.Dispose();
        }
    }
}
