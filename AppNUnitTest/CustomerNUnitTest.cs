using App;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        private Customer customer;

        [SetUp] 
        public void setup() // to be run before any other test methods
        {
            customer = new Customer();
        }

        [Test]
        [TestCase("Mohamed","Amr")]
        [TestCase("Ahmed", "Aly")]
        public void GreetingAndCombine_Test(string firstName,string lastName)
        {
            // Arrange
            // already did in setup

            //Act
            string result = customer.GreetingAndCombineName(firstName, lastName);
            // Assert
            string expectedValue = $"Hello, {firstName} {lastName}";

            Assert.That(result, Is.EqualTo(expectedValue));
            //ClassicAssert.AreEqual(expectedValue, result);
        }

        [Test]
        public void GreetingAndCombine_Greet_shouldBeNull()
        {
            //Arrange
            // already did in setup

            //Act
            //nothing needed

            //Assert
            ClassicAssert.IsNull(customer.Greeting);
        }
    }
}
