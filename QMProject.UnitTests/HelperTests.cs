using NUnit.Framework;
using System.Net.Http;
using QMproject.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using FakeItEasy;
using QMproject.Helpers;
using System;

namespace QMProject.UnitTests
{
    public class HelperTests
    {
        [Test]
        [TestCase("12-01-2001", "20/01/2010")]
        [TestCase("01/08/2021", "20-01/2010")]
        [TestCase("01/08/21", " ")]
        public void DateHelper_CalculateDifference_Returns_Empty_Result(string Date1, string Date2)
        {
            //Arrange


            //Act

            var actualResult = DateHelper.CalculateDateDifference(Date1, Date2);

            //Assert

            Assert.IsFalse(actualResult.Length > 0);


        }

        [Test]
         public void DateHelper_CalculateDifference_Returns_Valid_Result()
        {
            //Arrange

            var Date1 = "12/01/2001";
            var Date2 = "20/01/2010";

            //Act

            var actualResult = DateHelper.CalculateDateDifference(Date1, Date2);

            //Assert

            Assert.IsTrue(actualResult.Length > 0);
            Assert.AreEqual(actualResult, "3295 days");

        }

        [Test]
        [TestCase("12/01/2001", "20/01/2010")]
        [TestCase("01/08/2021", "20/01/2010")]
        [TestCase("01/08/2021", "20/01/1990")]
        public void DateHelper_CalculateDifference_Returns_Result(string Date1, string Date2)
        {
            //Arrange

            //Act

            var actualResult = DateHelper.CalculateDateDifference(Date1, Date2);

            //Assert

            Assert.IsTrue(actualResult.Length > 0);

        }

        
    }
}