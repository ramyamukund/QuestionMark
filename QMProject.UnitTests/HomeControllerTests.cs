using NUnit.Framework;
using System.Net.Http;
using QMproject.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using FakeItEasy;
using QMproject.Controllers;
using Microsoft.Extensions.Logging;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace QMProject.UnitTests
{
    public class HomeControllerTests
    {
        [Test]
        public void UserController_Calculate_Test()
        {
            //Arrange

            var logger = new NullLogger<HomeController>();

            var controller = new HomeController(logger);

            var userInputModel = new UserInputModel();
            userInputModel.Date1 = "12/01/2000";
            userInputModel.Date2 = "12/10/2010";

            //Act

            var actualResult = controller.Calculate(userInputModel) as ViewResult;
     
            //Assert

            Assert.That(actualResult, Is.InstanceOf<ViewResult>());
            Assert.AreEqual(actualResult.ViewName, "Index");
           
        }
    }
}
