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
        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(27)]
        public void isOddNumber_InputOddInt_GetTrue(int number)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.isOddNumber(number);

            // Assert
            ClassicAssert.IsTrue(result);
            
        }

        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(26)]
        public void isOddNumber_InputEvenInt_GetFalse(int number)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.isOddNumber(number);

            // Assert
            ClassicAssert.IsFalse(result);
            //Assert.That(result,Is.False);
        }

        [Test]
        [TestCase(10,ExpectedResult =false)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(21, ExpectedResult = true)]
        [TestCase(23, ExpectedResult = true)]
        public bool isOddNumber_InputNum_returnTrueIfOdd(int number)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool result = calculator.isOddNumber(number);


            // Assert will be done by framework
            // it will compare the returned value of this method with expected result
            return result;
        }

        [Test]
        public void OddRanger_InputMinMaxRange_ReturnsValidRange()
        {

            //Arrange
            Calculator calculator = new Calculator();
            List<int> expectedOddRange = new List<int>() { 3, 5, 7,9 };


            //Act
            List<int> result = calculator.getOddRange(2, 10);

            // Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }
    }
}
