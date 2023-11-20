using Microsoft.AspNetCore.Mvc;
using SEIITestForAmericanSpecialtyProject.Models;
using SEIITestForAmericanSpecialtyProject.Services;

namespace SEIITestForAmericanSpecialtyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;

        public PersonController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult GetAllPeople()
        {
            var people = _personService.GetAllPeople();
            return Ok(people);
        }

        [HttpPost]
        public IActionResult AddPerson([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Person data is required.");
            }

            // Validate the model using Data Annotations
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _personService.AddPerson(person);
                return Ok("Person added successfully");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal Server Error");
            }
        }
    }


}
