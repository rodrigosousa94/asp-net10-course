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

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] long id)
        {
            var person = _personService.FindById(id);
            if(person != null)
            {
                return Ok(person);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var createdPerson = _personService.Create(person);
            if(createdPerson == null)
            {
                return BadRequest();
            }
            return Ok(createdPerson);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var updatedPerson = _personService.Update(person);
            if(updatedPerson == null)
            {
                return BadRequest();
            }
            return Ok(updatedPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            _personService.Delete(id);
            return NoContent();
        }

    }
}
