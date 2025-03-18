using Microsoft.AspNetCore.Mvc;
using MVCRepositoryApp.Controllers;
using MVCRepositoryApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRespoistoryTests
{
    [TestClass]
    public class OrganizationControllerTestCases
    {
        [TestMethod]
        public void IndexActionShouldNotReturnNull()
        {
            //Arrange
           // var fake = MOck(IOrganizationRepository).Count()=>10;
            var controller = new HomeController(new FakeRepository());

            //act
             var result = controller.Index();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexActionShouldRetunAViewResult() { 
        
            //Arrange
            var controller = new HomeController(new FakeRepository());
            var result = controller.Index();

            //check type of result is ViewResult
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        
        }


    }
}
