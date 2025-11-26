using aspnet10.Services;
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
        public IActionResult GetSqrt([FromRoute] string number)
        {
            if (Metods.IsNumeric(number))
            {
                var result = Metods.ConvertToDecimal(number);
                result = (decimal)MathService.SquareRoot((double)result);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}
