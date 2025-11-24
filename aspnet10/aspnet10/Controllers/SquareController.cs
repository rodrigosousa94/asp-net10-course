using aspnet10.Model;
using aspnet10.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquareController : ControllerBase
    {
        [HttpGet("{number}")]
        public IActionResult GetSqrt([FromRoute] Numbers numbers)
        {
            if (Metods.IsNumeric(numbers.number))
            {
                var result = Metods.ConvertToDecimal(numbers.number);
                result = (decimal)Math.Sqrt((double)result);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}
