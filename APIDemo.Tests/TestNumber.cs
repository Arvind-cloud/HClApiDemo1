using APIDemo1.Controllers;
using APIDemo1.Interface;
using APIDemo1.Models;
using APIDemo1.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System;
using System.Net.Http;
using System.Web.Http;

namespace APIDemo.Tests
{

    [TestClass]
    public class TestNumber
    {
        [TestMethod]
        public void ReturnSuccess_test()
        {
            //Arrange
            NumberClass obj = new NumberClass()
            {
                Number = 2,
                Divisor = 3
            };
            INumber number = new NumberService();
            var controller = new NumberController(number);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var response = controller.GetDetails(obj);

            //Assert
            Assert.AreEqual(response, 6);
        }
    }
}
