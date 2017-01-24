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

        [Test]
        public void Input2_Return2()
        {
            var expectedResult = "2";
            var actualOutput = numOp.CocaColaOperator(2);

            Assert.AreEqual(expectedResult, actualOutput);
        }

        [Test]
        public void Input3_ReturnCoca()
        {
            var expectedResult = "Coca";
            var actualOutput = numOp.CocaColaOperator(3);

            Assert.AreEqual(expectedResult, actualOutput);
        }

        [Test]
        public void Test_Input5_Return_Cola()
        //Test the output of progrem when the number is 
        {
            // Arrange: Define a test output value
            var expectedOutput = "Cola";

            // Act: Run the method under test
            var actualOutput = numOp.CocaColaOperator(5);

            // Assert: Verify the result
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
