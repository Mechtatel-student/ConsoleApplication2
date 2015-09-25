using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication1;

namespace ClassLibrary1
{
    [TestFixture, Description("Testing main static methods")]
    class TestMainProgram
    {
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(15, Program.Sum(10, 5));
            Assert.AreEqual(15, Program.Sum(5,10));
        }

        [TestCase]
        [TestCase(15,5,10)]
        [TestCase(34,45,-11)]
        public void TestCaseSum(int result,int op1, int op2)
        {
            Assert.DoesNotThrow();
            Assert.AreEqual(result, Program.Sum(op1,op2));
            
        }
    }
}
