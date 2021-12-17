using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAllPerson();
        Person GetPersonById(int id);
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        void DeletePerson(int id);
    }
}
