using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Business.Abstract;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsControllers : ControllerBase
    {
        private IContactService _contactService;

        public ContactsControllers(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _contactService.GetContactById(id);
        }

        [HttpPost]
        public Contact Post([FromBody]Contact contact)
        {
            return _contactService.CreateContact(contact);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactService.DeleteContact(id);
        }


    }
}
