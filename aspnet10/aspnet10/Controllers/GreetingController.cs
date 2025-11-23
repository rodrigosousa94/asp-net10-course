using aspnet10.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {

        private static long _counter = 0;
        private static readonly string _template = "Hello, {0}";

        [HttpGet]
        public Greeting Get([FromQuery] string name = "World")
        {
            var id = Interlocked.Increment(ref _counter);
            var content = string.Format(_template, name);
            return new Greeting(id, content);     
        }
    }
}
