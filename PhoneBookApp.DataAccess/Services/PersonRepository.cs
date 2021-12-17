using PhoneBook.Entities;
using PhoneBookApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp.DataAccess.Services
{
    public class PersonRepository : IPersonRepository
    {
        public Person CreatePerson(Person person)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.Persons.Add(person);
                phoneDbContext.SaveChanges();
                return person;
            }
        }

        public void DeletePerson(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                var deletePerson = GetPersonById(id);
                phoneDbContext.Persons.Remove(deletePerson);
                phoneDbContext.SaveChanges();
            }
        }

        public List<Person> GetAllPerson()
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                return phoneDbContext.Persons.ToList();
            }
        }

        public Person GetPersonById(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                return phoneDbContext.Persons.Find(id);
            }
        }

        public Person UpdatePerson(Person person)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.Persons.Update(person);                
                return person;
            }
        }
    }
}
