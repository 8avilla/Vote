using System;
using System.Collections.Generic;
using Vote.Domain.Entities;

namespace Vote.Service.Interfaces
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetAll();
        public Person GetById(Guid id);
        public Person Add(Person person);
        public Person Update(Guid id, Person person);
        public void Delete(Guid id);
    }
}