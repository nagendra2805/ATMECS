using ContactsWebAPI.Controllers;
using ContactsWebAPI.Interfaces;
using ContactsWebAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class ContactControllerTests
    {
        [Fact]
        public void ShouldThrowExceptionIfConstructorArgumentsPassedNull()
        {
            Action action = () => new ContactController(null);

            var exceptionDetails = action.Should().Throw<ArgumentNullException>();
            exceptionDetails.Should().NotBeNull();
            exceptionDetails.Which.Message.Should().NotBeNullOrWhiteSpace();

        }

        [Fact]
        public void ShouldReturnOkStatusCodeForAValidRequest()
        {
            var contact = new Contact() { FirstName = "dummynfame", LastName= "dummylname", DateofBirth = Convert.ToDateTime("05/05/2020"),
            MobileNumbers = new List<string>() { "123456789" }, EmailIds = new List<string>() { "some@gmail.com" },
            };
            var mockContactservice = new Mock<IContactService>();
            mockContactservice.Setup(_ => _.CreateContact(contact));

            var actionContext = new ActionContext
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new Microsoft.AspNetCore.Routing.RouteData(),
                ActionDescriptor = new ControllerActionDescriptor()
            };

            var contactController = new ContactController(mockContactservice.Object) { ControllerContext = new ControllerContext(actionContext) };
            // Act
            var result = contactController.Post(contact);

            // Assert
            result.Should().NotBeNull()
                .And
                .BeOfType<OkObjectResult>()
                .Which
                .StatusCode.Should().Be(200);

            var resultResponse = result as OkObjectResult;
        }
        [Fact]
        public void ShouldReturn400BadRequestStatusCodeForAInValidRequest()
        {
            Contact contact = null;
            var mockContactservice = new Mock<IContactService>();
            mockContactservice.Setup(_ => _.CreateContact(contact));

            var actionContext = new ActionContext
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new Microsoft.AspNetCore.Routing.RouteData(),
                ActionDescriptor = new ControllerActionDescriptor()
            };

            var contactController = new ContactController(mockContactservice.Object) { ControllerContext = new ControllerContext(actionContext) };
            // Act
            var result = contactController.Post(contact);

            // Assert
            result.Should().NotBeNull()
                .And
                .BeOfType<BadRequestObjectResult>()
                .Which
                .StatusCode.Should().Be(400);

            var resultResponse = result as BadRequestObjectResult;
        }
    }
}
