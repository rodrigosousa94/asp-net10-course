using aspnet10.Model;
using aspnet10.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AverageControllers : ControllerBase
    {
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult GetAverage([FromRoute] Numbers numbers)
        {
            if (Metods.IsNumeric(numbers.firstNumber) && Metods.IsNumeric(numbers.secondNumber))
            {
                var result = (Metods.ConvertToDecimal(numbers.firstNumber) + Metods.ConvertToDecimal(numbers.secondNumber)) / 2;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}
