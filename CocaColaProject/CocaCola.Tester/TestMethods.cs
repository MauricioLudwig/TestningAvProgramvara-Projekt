using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumberOperator.Library;

namespace CocaCola.Tester
{
    [TestFixture]
    public class TestMethods
    {
        // Create an instance to test:  
        NumOperator numOp = new NumOperator();
        #region Test input 1
        [Test]
        public void Test_Input1_Return1()
        //Test the output of progrem when the number is 1
        {
            // Arrange: Define a test output value
            var expectedOutput = "1";

            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(1);

            // Assert: Verify the result
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        #endregion

        #region Sequential Test that test many inputs with many outputs
        [Test, Sequential]
        public void Input_MoreThanOne_Return_ManyAlternatives(
            [Values(64, 36, 50, 2, 15)]int input,
            [Values("64", "Coca", "Cola","2", "CocaCola")] string expectedResult)
        //Test the output of progrem when the number is 
        {
            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(input);
            // Assert: Verify the result
            Assert.AreEqual(expectedResult, actualOutput);
        }
        #endregion

        #region Test input that return Coca
        [Test]
        public void Input_That_Return_Coca(
            [Values(3, 9, 12, 18, 21)] int input)
        //Test the output of progrem when the number is 
        {
            // Arrange: Define a test output value
            var expectedResult = "Coca";
            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(input);
            // Assert: Verify the result
            Assert.AreEqual(expectedResult, actualOutput);
        }
        #endregion

        #region Test input that return Cola
        [Test]
        public void Test_Input_That_Return_Cola(
            [Values(5, 10, 20, 25)] int input)
        //Test the output of progrem when the number is 
        {
            // Arrange: Define a test output value
            var expectedOutput = "Cola";

            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(input);

            // Assert: Verify the result
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        #endregion

        #region Test input that return CocaCola
        [Test]
        public void Test_Input_That_Return_CocaCola(
            [Values(15, 30, 45, 60, 75, 90)] int input)
        //Test the output of program when the number is 
        {
            // Arrange: Define a test output value
            var expectedOutput = "CocaCola";

            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(input);

            // Assert: Verify the result
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        #endregion
    }
}
