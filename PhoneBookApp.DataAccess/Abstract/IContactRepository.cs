using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.DataAccess.Abstract
{
    public interface IContactRepository
    {
        List<Contact> GetAllContact();
        Contact CreateContact(Contact contact);
        Contact UpdateContact(Contact contact);

    }
}
