using aspnet10.Model;
using aspnet10.Model.Context;
using aspnet10.Repositories;
using System;

namespace aspnet10.Services.Impl
{
    public class PersonServicesImpl : IPersonService
    {

        private IPersonRepository _repository;
        public PersonServicesImpl(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {   
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
