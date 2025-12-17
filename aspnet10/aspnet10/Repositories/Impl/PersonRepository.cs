using aspnet10.Model;
using aspnet10.Model.Context;

namespace aspnet10.Repositories.Impl
{
    public class PersonRepository : IPersonRepository
    {
        private MSSQLContext _context;
        public PersonRepository(MSSQLContext context)
        {
            _context = context;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _context.Persons.Find(id);
        }

        public Person Create(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }

        public Person Update(Person person)
        {

            var personToUpdated = _context.Persons.Find(person.Id);

            if (personToUpdated == null) return null;

            _context.Entry(personToUpdated).CurrentValues.SetValues(person);
            _context.SaveChanges();
            return personToUpdated;
        }

        public void Delete(long id)
        {
            var personToUpdated = _context.Persons.Find(id);

            if (personToUpdated == null) return;

            _context.Persons.Remove(personToUpdated);
            _context.SaveChanges();
        }
    }
}

