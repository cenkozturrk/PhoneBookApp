using PhoneBookApp.DataAccess.Abstract;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp.DataAccess.Services
{
    public class ContactRepository : IContactRepository
    {
        public Contact CreateContact(Contact contact)
        {
            using (var phoneDbContact = new PhoneDbContext())
            {
                phoneDbContact.Contacts.Add(contact);
                phoneDbContact.SaveChanges();
                return contact;

            }
        }

        public List<Contact> GetAllContact()
        {
           using(var phoneDbContact = new PhoneDbContext())
            {
                return phoneDbContact.Contacts.ToList();
            }
        }

        public Contact UpdateContact(Contact contact)
        {
            using(var phoneDbContext = new PhoneDbContext())
            {
                phoneDbContext.Contacts.Update(contact);
                phoneDbContext.SaveChanges();
                return contact;
            }
        }
    }
}
