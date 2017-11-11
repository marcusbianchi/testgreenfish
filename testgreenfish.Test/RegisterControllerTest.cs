using Xunit;
using Moq;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testgreenfish.Models;
using testgreenfish.Services.Interfaces;
using testgreenfish.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace testgreenfish.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetWithouErrors()
        {
            // Arrange
            RegisterServicesMock registerMock = new RegisterServicesMock();
            var controller = new RegisterController(registerMock);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewData["Message"]);

        }

        [Fact]
        public void PostAlreadyExistingData()
        {
            // Arrange
            RegisterServicesMock registerMock = new RegisterServicesMock();
            var controller = new RegisterController(registerMock);
            var newEmail = new Email()
            {
                address = "marcusv.bianchisantos@gmail.com"
            };


            // Act
            var result = controller.Index(newEmail);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("This e-mail is already registered to the Database", viewResult.ViewData["Message"].ToString());

        }

        [Fact]
        public void PostNewData()
        {
            // Arrange
            RegisterServicesMock registerMock = new RegisterServicesMock();
            var controller = new RegisterController(registerMock);
            var newEmail = new Email()
            {
                address = "teste@gmail.com"
            };


            // Act
            var result = controller.Index(newEmail);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("E-mail added to mailing list", viewResult.ViewData["Message"].ToString());

        }

        private List<Email> GetEmails()
        {
            var emails = new List<Email>();
            emails.Add(new Email()
            {
                emailId = 1,
                address = "marcusv.bianchisantos@gmail.com"

            });

            return emails;
        }
    }
}
