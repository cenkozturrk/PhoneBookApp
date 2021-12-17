using PhoneBook.Entities;
using PhoneBookApp.Business.Abstract;
using PhoneBookApp.DataAccess.Abstract;
using PhoneBookApp.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public Person CreatePerson(Person person)
        {
            return _personRepository.CreatePerson(person);
        }

        public void DeletePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }

        public List<Person> GetAllPerson()
        {
            return _personRepository.GetAllPerson();
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.GetPersonById(id);
        }

        public Person UpdatePerson(Person person)
        {
            return _personRepository.UpdatePerson(person);
        }
    }
}
