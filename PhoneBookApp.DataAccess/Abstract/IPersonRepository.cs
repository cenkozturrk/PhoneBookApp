using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.DataAccess.Abstract
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();

        Person GetHotelById(int id);

        Person CreatePerson(Person hotel);

        Person UpdatePerson(Person person);

        void DeleteHotel(int id);
    }
}
