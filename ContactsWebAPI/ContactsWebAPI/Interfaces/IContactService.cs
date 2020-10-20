using ContactsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebAPI.Interfaces
{
    public interface IContactService
    {
        List<Contact> CreateContact(Contact contact);
    }
}
