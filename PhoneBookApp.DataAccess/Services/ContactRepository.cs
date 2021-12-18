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

        public Contact GetContactById(int id)
        {
           using(var phoneDbContact = new PhoneDbContext())
            {
                return phoneDbContact.Contacts.Find(id);
            }
        }

        public void DeleteContact(int id)
        {
            using (var phoneDbContext = new PhoneDbContext())
            {
                var deleteContact = GetContactById(id);
                phoneDbContext.Contacts.Remove(deleteContact);
                phoneDbContext.SaveChanges();
            }
        }
    }
}
