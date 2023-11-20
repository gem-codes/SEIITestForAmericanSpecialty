using SEIITestForAmericanSpecialtyProject.Models;

namespace SEIITestForAmericanSpecialtyProject.Interfaces
{
    public interface IPersonService
    {
        void AddPerson(Person person);

        IEnumerable<Person> GetAllPeople();
    }
}
