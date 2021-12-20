using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
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
        private readonly IDistributedCache _redisDistributedCache;

        public PersonsControllers(IPersonService personService, IDistributedCache redisDistributedCache)
        {
            _personService = personService;
            _redisDistributedCache = redisDistributedCache;
        }

        [HttpGet]
        public async Task<List<Person>> Get()
        {
            return await _personService.GetAllPerson();
        }

        [HttpGet("{id}")]

        public async Task<Person> Get(int id)
        {
            return await _personService.GetPersonById(id);
        }

        [HttpPost]
        public async Task<Person> Post([FromBody]Person person)
        {
            return await _personService.CreatePerson(person);
        }

        [HttpPut]
        public async Task<Person> Put([FromBody] Person person)
        {
            return await _personService.UpdatePerson(person);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _personService.DeletePerson(id);

        }


    }
}
