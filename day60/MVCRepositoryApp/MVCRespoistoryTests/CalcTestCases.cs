using MVCRepositoryApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRespoistoryTests
{
    
    [TestClass]
    public class CalcTestCases
    {
        [TestMethod]
        public void AddingPostiveValues()
        {

            //Arrange , System Under Test
            var calc = new Calc();
            var expected = 300;

            //Act
            var actualResult = calc.Add(10, 20);
            //Assert

            Assert.AreEqual(expected, actualResult);

        }
        [TestMethod]
        public void AddingNegativesValues()
        {

            //Arrange , System Under Test
            var calc = new Calc();
            var expected = -30;

            //Act
            var actualResult = calc.Add(-10, -20);
            //Assert

            Assert.AreEqual(expected, actualResult);

        }
    }
}
