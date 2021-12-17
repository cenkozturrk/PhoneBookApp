using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.DataAccess.Abstract
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();

        Person GetPersonById(int id);

        Person CreatePerson(Person person);

        Person UpdatePerson(Person person);

        void DeletePerson(int id);
    }
}
