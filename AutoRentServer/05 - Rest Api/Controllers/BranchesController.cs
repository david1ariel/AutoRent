﻿using System;
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
    public class BranchesController : ControllerBase, IDisposable
    {
        private readonly BranchesLogic branchesLogic;

        public BranchesController(BranchesLogic branchesLogic)
        {
            this.branchesLogic = branchesLogic;
        }



        [HttpGet]
        public IActionResult GetAllBranches()
        {
            try
            {
                return Ok(branchesLogic.GetAllBranches());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        public void Dispose()
        {
            branchesLogic.Dispose();
        }

    }
}
