using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Business.Abstract
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllPerson();
        Task<Person> GetPersonById(int id);
        Task<Person> CreatePerson(Person person);
        Task<Person> UpdatePerson(Person person);
        Task DeletePerson(int id);
    }
}
