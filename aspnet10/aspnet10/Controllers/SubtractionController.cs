using aspnet10.Model;
using aspnet10.Services;
using aspnet10.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtractionController : ControllerBase
    {

        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtraction([FromRoute] Numbers numbers)
        {
            if (Metods.IsNumeric(numbers.firstNumber) && Metods.IsNumeric(numbers.secondNumber))
            {
                var result = MathService.Subtraction(Metods.ConvertToDecimal(numbers.firstNumber), Metods.ConvertToDecimal(numbers.secondNumber));
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}
