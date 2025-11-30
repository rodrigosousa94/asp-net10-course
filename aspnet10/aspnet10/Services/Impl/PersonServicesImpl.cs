using aspnet10.Model;

namespace aspnet10.Services.Impl
{
    public class PersonServicesImpl : IPersonService
    {

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson(i));
            }

            return persons;
        }

        public Person FindById(long id)
        {   
            var person = MockPerson((int)id);

            return person;

        }


        public Person Create(Person person)
        {
            person.Id = new Random().Next(1, 1000);
            return person;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // retornara vazio
        }
        private Person MockPerson(int i)
        {
            var person = new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "Leandro" + i,
                LastName = "Costa",
                Address = "Uberlândia - MG - Brasil",
                Gender = "Male"
            };

            return person;
        }

    }
}
