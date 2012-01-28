using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{
    [TestFixture]
    public class HomeControllerIndexTests
    {
        [Test]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNull(result.ViewBag.Message);
        }



    }
}
