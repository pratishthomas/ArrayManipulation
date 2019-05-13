using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayManipulation.Api.Utilties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArrayManipulation.Api.Controllers
{
    [Route("api/arraycalc")]
    public class ArrayManipulationController : Controller
    {

        [HttpGet("reverse")]
        public IActionResult Reverse(int[] productIds)
        {

            try
            {
                return Ok(ArrayUtility.Reverse(productIds));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error");
            }
        }

        [HttpGet("deletepart")]
        public IActionResult DeletePart(int position, int[] productIds)
        {
            try
            {
                return Ok(ArrayUtility.DeleteElementAtIndex(position, productIds));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error");
            }
        }


    }
}
