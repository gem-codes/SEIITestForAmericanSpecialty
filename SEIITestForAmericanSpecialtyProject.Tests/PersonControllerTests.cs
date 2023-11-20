using Microsoft.AspNetCore.Mvc;
using Moq;
using SEIITestForAmericanSpecialtyProject.Controllers;
using SEIITestForAmericanSpecialtyProject.Models;
using SEIITestForAmericanSpecialtyProject.Services;
using System;

namespace SEIITestForAmericanSpecialtyProject.Tests
{
    // Add necessary using statements for Xunit and Moq if not already added

    public class PersonControllerTests
    {
        [Fact]
        public void GetAllPeople_Returns_OkResult()
        {
            // Arrange
            var mockPersonService = new Mock<PersonService>();
            mockPersonService.Setup(service => service.GetAllPeople())
                             .Returns(new List<Person>());

            var controller = new PersonController(mockPersonService.Object);

            // Act
            var result = controller.GetAllPeople();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAllPeople_Returns_InternalServerError_OnException()
        {
            // Arrange
            var mockPersonService = new Mock<PersonService>();
            mockPersonService.Setup(service => service.GetAllPeople())
                             .Throws(new Exception("Simulated error"));

            var controller = new PersonController(mockPersonService.Object);

            // Act
            var result = controller.GetAllPeople();

            // Assert
            Assert.IsType<ObjectResult>(result);
            var statusCode = (result as ObjectResult).StatusCode;
            Assert.Equal(500, statusCode);
        }

        [Fact]
        public void AddPerson_Returns_OkResult()
        {
            // Arrange
            var mockPersonService = new Mock<PersonService>();
            mockPersonService.Setup(service => service.AddPerson(It.IsAny<Person>()));

            var controller = new PersonController(mockPersonService.Object);

            // Act
            var result = controller.AddPerson(new Person());

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddPerson_Returns_InternalServerError_OnException()
        {
            // Arrange
            var mockPersonService = new Mock<PersonService>();
            mockPersonService.Setup(service => service.AddPerson(It.IsAny<Person>()))
                             .Throws(new Exception("Simulated error"));

            var controller = new PersonController(mockPersonService.Object);

            // Act
            var result = controller.AddPerson(new Person());

            // Assert
            Assert.IsType<ObjectResult>(result);
            var statusCode = (result as ObjectResult).StatusCode;
            Assert.Equal(500, statusCode);
        }
    }

}