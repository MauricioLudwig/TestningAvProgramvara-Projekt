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
            var expectedOutput = "1";
            var actualOutput = numOp.CocaColaOperator(1);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
