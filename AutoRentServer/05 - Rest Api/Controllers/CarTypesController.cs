using System;
using System.Collections.Generic;
using System.IO;
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
    public class CarTypesController : ControllerBase
    {
        private readonly CarTypesLogic carTypesLogic;

        public CarTypesController(CarTypesLogic carTypesLogic)
        {
            this.carTypesLogic = carTypesLogic;
        }



        [HttpGet]
        public IActionResult GetAllCarTypes()
        {
            try
            {
                return Ok(carTypesLogic.GetAllCarTypes());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult UpdateCarType(int id, [FromForm] CarTypeModel carTypeModel)
        {
            try
            {
                return Ok(carTypesLogic.UpdateCarType(carTypeModel));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch]
        [Route("update-many")]
        public IActionResult UpdateManyCarTypes([FromForm] List<CarTypeModel> carTypeModels)
        {
            try
            {
                return Ok(carTypesLogic.UpdateManyCarTypes(carTypeModels));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("images/{fileName}")]
        public IActionResult GetImage(string fileName)
        {
            try
            {
                // Open a stream to the file: 
                FileStream fileStream = System.IO.File.OpenRead("Uploads/" + fileName);

                // Send back the stream to the client: 
                return File(fileStream, "image/jpeg");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            carTypesLogic.Dispose();
        }
    }
}
