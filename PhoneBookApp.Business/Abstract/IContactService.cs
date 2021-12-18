using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAllContact();
        Contact CreateContact(Contact contact);
        Contact UpdateContact(Contact contact);
    }
}
