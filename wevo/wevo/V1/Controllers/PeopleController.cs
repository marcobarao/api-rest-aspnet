using Microsoft.AspNetCore.Mvc;
using wevo.Model;
using wevo.Business;
using wevo.Data.VO;

namespace wevo.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PeopleController : ControllerBase
    {
        private IPeopleBusiness _peopleBusiness;

        public PeopleController(IPeopleBusiness peopleBusiness)
        {
            _peopleBusiness = peopleBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_peopleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            PersonVO People = _peopleBusiness.FindById(id);

            if (People == null) return NotFound();
            return Ok(People);
        }

        [HttpPost]
        public IActionResult Post([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_peopleBusiness.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            PersonVO updatedPerson = _peopleBusiness.Update(person);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]PersonVO person)
        {
            _peopleBusiness.Delete(person);
            return NoContent();
        }
    }
}
