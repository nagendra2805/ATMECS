using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebAPI.Interfaces;
using ContactsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
        }


        
        [HttpPost]
        [Route("CreateorUpdateContact")]
        public IActionResult Post([FromBody] Contact contact)
        {
            if (contact == null)
                return BadRequest(contact);

            var contacts = _contactService.CreateContact(contact);

            return Ok(contacts);
        }

    }
}
