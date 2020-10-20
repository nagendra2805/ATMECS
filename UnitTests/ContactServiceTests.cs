using ContactsWebAPI.Controllers;
using ContactsWebAPI.Interfaces;
using ContactsWebAPI.Models;
using ContactsWebAPI.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class ContactServiceTests
    {
        [Fact]
        public void ShouldReturnListofContacts()
        {
            var contact = new Contact()
            {
                FirstName = "dummynfame",
                LastName = "dummylname",
                DateofBirth = Convert.ToDateTime("05/05/2020"),
                MobileNumbers = new List<string>() { "123456789" },
                EmailIds = new List<string>() { "some@gmail.com" },
            };

            var service = new ServiceCollection();
            service.AddTransient<IContactService, ContactService>();
            var serviceProvider = service.BuildServiceProvider();

            var contactservice = serviceProvider.GetRequiredService<IContactService>();

            var response = contactservice.CreateContact(contact);
            response.Should().NotBeNull();
            response.Should().BeOfType<List<Contact>>();
        }
    }
}
