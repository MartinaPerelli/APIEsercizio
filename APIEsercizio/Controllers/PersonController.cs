using Microsoft.AspNetCore.Mvc;

namespace APIEsercizio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        public static List<Person> people = new List<Person>();


        [HttpPost]
        public List<Person> AddPeople(List<Person> peopleCollection)
        {

            people = (peopleCollection);
            return people;
        }

        [HttpGet]
        public List<Person> GetPeopleList()
            {
            return people;
            }

        [HttpGet("{value}")]
        public Person GetPersonAtIndex(int value)
        {
            return people.ElementAt(value);
        }

        [HttpGet("GetPeople/{id}")]
        public IEnumerable<Person> GetPeopleWithId(int id)
        {
            return people.Where(person => person.Id == id);
        }

        [HttpDelete("RemovePerson/{id}")]
        public bool RemovePerson(int id)
        {
            var person = people.ElementAt(id);
            return people.Remove(person);
        }
    }
}
