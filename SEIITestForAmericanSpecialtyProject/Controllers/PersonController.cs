using Microsoft.AspNetCore.Mvc;
using SEIITestForAmericanSpecialtyProject.Interfaces;
using SEIITestForAmericanSpecialtyProject.Models;
using SEIITestForAmericanSpecialtyProject.Services;

namespace SEIITestForAmericanSpecialtyProject.Controllers
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
        public IActionResult GetAllPeople()
        {
            try
            {
                // Your logic to get all people
                var people = _personService.GetAllPeople();
                return Ok(people);
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                Console.WriteLine(ex.Message);

                // Return a 500 Internal Server Error
                return StatusCode(500, "Internal Server Error");
            }
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
