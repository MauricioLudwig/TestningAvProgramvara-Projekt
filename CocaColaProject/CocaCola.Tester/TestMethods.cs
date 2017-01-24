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
        NumOperator numOp = new NumOperator();
        [Test]
        public void Test_Input1_Return1()
        {
            // Arrange
            var expectedOutput = "1";

            // Act
            var actualOutput = numOp.CocaColaOperator(1);

            // Assert
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
        public void Input3_ReturnCola()
        {
            var expectedResult = "Cola";
            var actualOutput = numOp.CocaColaOperator(3);

            Assert.AreEqual(expectedResult, actualOutput);
        }

    }
}
