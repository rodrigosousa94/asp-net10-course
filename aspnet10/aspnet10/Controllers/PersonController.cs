using aspnet10.Model;
using aspnet10.Services;
using aspnet10.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonService personService, ILogger<PersonController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Getting all persons");
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] long id)
        {
            _logger.LogInformation("Getting person ID: {id}", id);

            var person = _personService.FindById(id);
            if(person != null)
            {
                return Ok(person);
            }

            _logger.LogWarning("Person not found: {id}", id);
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            _logger.LogInformation("Creating person");

            var createdPerson = _personService.Create(person);
            if(createdPerson == null)
            {
                _logger.LogWarning("Person not found: {id}", person.Id);
                return BadRequest();
            }
            return Ok(createdPerson);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            _logger.LogInformation("Updating person");

            var updatedPerson = _personService.Update(person);
            if(updatedPerson == null)
            {
                _logger.LogWarning("Person not found: {id}", person.Id);
                return BadRequest();
            }
            return Ok(updatedPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            _logger.LogInformation("Deleting person");

            _personService.Delete(id);
            return NoContent();
        }

    }
}
