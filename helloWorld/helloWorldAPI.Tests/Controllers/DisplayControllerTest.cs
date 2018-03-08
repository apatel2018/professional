using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using helloWorldAPI;
using helloWorldAPI.Controllers;

namespace helloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class DisplayControllerTest
    {
        [TestMethod]
        public void TestGetDisplay()
        {
            // Arrange
            DisplayController controller = new DisplayController();

            // Act
            string result = controller.GetDisplay(); 

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
