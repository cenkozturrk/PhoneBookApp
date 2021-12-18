using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Entities;
using PhoneBookApp.Business.Abstract;
using PhoneBookApp.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsControllers : ControllerBase
    {
        private IPersonService _personService;

        public PersonsControllers(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public List<Person> Get()
        {
            return _personService.GetAllPerson();
        }

        [HttpGet("{id}")]

        public Person Get(int id)
        {
            return _personService.GetPersonById(id);
        }

        [HttpPost]
        public Person Post([FromBody]Person person)
        {
            return _personService.CreatePerson(person);
        }

        [HttpPut]
        public Person Put([FromBody]Person person)
        {
            return _personService.UpdatePerson(person);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.DeletePerson(id);

        }


    }
}
