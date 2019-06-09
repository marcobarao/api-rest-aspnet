﻿using Microsoft.AspNetCore.Mvc;
using wevo.Business;
using wevo.Data.VO;
using Tapioca.HATEOAS;
using System.Collections.Generic;
using NSwag;
using Swashbuckle.AspNetCore.SwaggerGen;

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
        [SwaggerResponse(200, Type = typeof(List<PersonVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_peopleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(PersonVO))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            PersonVO People = _peopleBusiness.FindById(id);

            if (People == null) return NotFound();
            return Ok(People);
        }

        [HttpPost]
        [SwaggerResponse(201, Type = typeof(PersonVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_peopleBusiness.Create(person));
        }

        [HttpPut]
        [SwaggerResponse(202, Type = typeof(PersonVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            PersonVO updatedPerson = _peopleBusiness.Update(person);
            if (updatedPerson == null) return BadRequest();
            return new ObjectResult(updatedPerson);
        }

        [HttpDelete]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete([FromBody]PersonVO person)
        {
            _peopleBusiness.Delete(person);
            return NoContent();
        }
    }
}
