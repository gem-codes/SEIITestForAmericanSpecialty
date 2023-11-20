using SEIITestForAmericanSpecialtyProject.Models;
using SEIITestForAmericanSpecialtyProject.Repository;

namespace SEIITestForAmericanSpecialtyProject.Services
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;

        public PersonService(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _personRepository.GetAllPeople();
        }

        public void AddPerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            // Additional validation logic can be added here

            _personRepository.AddPerson(person);
        }
    }



}
