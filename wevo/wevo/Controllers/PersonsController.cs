using Microsoft.AspNetCore.Mvc;
using wevo.Model;
using wevo.Services;

namespace wevo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Person person = _personService.FindById(id);

            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Person person)
        {
            _personService.Delete(person);
            return NoContent();
        }
    }
}
