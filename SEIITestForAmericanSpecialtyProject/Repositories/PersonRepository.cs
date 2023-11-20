using SEIITestForAmericanSpecialtyProject.DbContextFactory;
using SEIITestForAmericanSpecialtyProject.Models;

namespace SEIITestForAmericanSpecialtyProject.Repository
{
    public class PersonRepository
    {
        private readonly AppDbContext _dbContext;

        public PersonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _dbContext.Person.ToList();
        }

        public void AddPerson(Person person)
        {
            _dbContext.Person.Add(person);
            _dbContext.SaveChanges();
        }
    }



}
