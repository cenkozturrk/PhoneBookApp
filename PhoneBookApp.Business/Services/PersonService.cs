using PhoneBook.Entities;
using PhoneBookApp.Business.Abstract;
using PhoneBookApp.DataAccess.Abstract;
using PhoneBookApp.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Business.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person> CreatePerson(Person person) 
        {
            return await _personRepository.CreatePerson(person);
        }

        public async Task DeletePerson(int id)
        {
            await _personRepository.DeletePerson(id);
        }

        public async Task<List<Person>> GetAllPerson()
        {
            return await _personRepository.GetAllPerson();
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await _personRepository.GetPersonById(id);
        }

        public async Task<Person> UpdatePerson(Person person)
        {
            return await _personRepository.UpdatePerson(person);
        }
    }
}
