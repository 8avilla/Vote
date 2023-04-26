using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructure.Persistence.Repository.Interfaces
using Vote.Domain.Entities;
using Vote.Service.Interfaces;

namespace Vote.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person Add(Person person)
        {
            if (person.Id == Guid.Empty)
            {
                person.Id = Guid.NewGuid();
            }

            _repository.Add(person);
            return _repository.GetById(person.Id);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public Person Update(Guid id, Person person)
        {
            throw new NotImplementedException();
        }

        
    }
}