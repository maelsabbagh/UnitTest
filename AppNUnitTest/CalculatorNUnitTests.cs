using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace AppNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calculator = new Calculator();


            //Act
            int result = calculator.AddNumber(2, 3);


            //Assert
            ClassicAssert.AreEqual(5, result);
        }
    }
}
