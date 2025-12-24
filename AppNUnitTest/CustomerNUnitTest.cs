using App;
using NUnit.Framework;
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
        [Test]
        [TestCase("Mohamed","Amr")]
        [TestCase("Ahmed", "Aly")]
        public void GreetingAndCombine_Test(string firstName,string lastName)
        {
            // Arrange
            Customer customer = new Customer();

            //Act
            string result = customer.GreetingAndCombineName(firstName, lastName);
            // Assert
            string expectedValue = $"Hello, {firstName} {lastName}";

            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
