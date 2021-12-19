using Microsoft.EntityFrameworkCore;
using PhoneBook.Entities;
using PhoneBookApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.DataAccess.Services
{
    public class PersonRepository : IPersonRepository
    {
        public async Task<Person> CreatePerson(Person person)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.Persons.Add(person);
                await phoneDbContext.SaveChangesAsync();
                return person;
            }
        }

        public async Task DeletePerson(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                var deletePerson = await GetPersonById(id);
                phoneDbContext.Persons.Remove(deletePerson);
                await phoneDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Person>> GetAllPerson()
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                return await phoneDbContext.Persons.ToListAsync();
            }
        }

        public async Task<Person> GetPersonById(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                return await phoneDbContext.Persons.FindAsync(id);
            }
        }

        public async Task<Person> UpdatePerson(Person person)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.Persons.Update(person);
                await phoneDbContext .SaveChangesAsync();
                return person;
            }
        }
    }
}
