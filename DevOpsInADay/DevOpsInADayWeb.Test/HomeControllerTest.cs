using DevOpsInADayWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DevOpsInADayWeb.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void ContactTest()
        {
            var controller = new HomeController(null);

            var result = controller.Contact();

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal("Your contact page.", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void AboutTest()
        {
            var controller = new HomeController(null);

            var result = controller.About();

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.Equal("Your application description page.", viewResult.ViewData["Message"]);
        }
    }
}
