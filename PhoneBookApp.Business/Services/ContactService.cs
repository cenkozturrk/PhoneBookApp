using PhoneBookApp.Business.Abstract;
using PhoneBookApp.DataAccess.Abstract;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Services
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.CreateContact(contact);
        }

        public List<Contact> GetAllContact()
        {
            return _contactRepository.GetAllContact();
        }

        public Contact UpdateContact(Contact contact)
        {
            return _contactRepository.UpdateContact(contact);
        }
    }
}
