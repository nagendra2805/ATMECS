using ContactsMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsMangementSystem.Interfaces
{
    public interface IContactService
    {
        List<Contact> CallContatcAPI(string requestUrl, Contact contact);
    }
}
