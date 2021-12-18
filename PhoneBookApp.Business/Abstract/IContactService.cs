using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.Business.Abstract
{
    public interface IContactService
    {
        Contact GetContactById(int id);
        Contact CreateContact(Contact contact);
        void DeleteContact(int id);
    }
}
