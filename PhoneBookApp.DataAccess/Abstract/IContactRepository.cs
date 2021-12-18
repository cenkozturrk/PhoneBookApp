using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.DataAccess.Abstract
{
    public interface IContactRepository
    {
        Contact GetContactById(int id);
        Contact CreateContact(Contact contact);
        void DeleteContact(int id);

    }
}
