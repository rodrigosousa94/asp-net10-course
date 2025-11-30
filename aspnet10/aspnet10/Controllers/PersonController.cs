using aspnet10.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonServicesImpl _personService;

        public PersonController(PersonServicesImpl personService)
        {
            _personService = personService;
        }
    }
}
