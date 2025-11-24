using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using aspnet10.Utils;
using aspnet10.Model;

namespace aspnet10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult Get([FromRoute] Numbers numbers)
        {
            if (Metods.IsNumeric(numbers.firstNumber) && Metods.IsNumeric(numbers.secondNumber))
            {
                var result = Metods.ConvertToDecimal(numbers.firstNumber) + Metods.ConvertToDecimal(numbers.secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }
    }
}
