using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator2;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanParseTermsFromGOOD2TermExpression()
        {
            BasicTasks doSomething = new BasicTasks();
            doSomething.RetrieveNumbers("8+2");
            Assert.AreEqual(doSomething.firstNumb, 8);
            Assert.AreEqual(doSomething.secNumb, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForIncorrectExpression()
        {
            //Doings.RetrieveNumbers("8+");
            BasicTasks doSomething = new BasicTasks();
            doSomething.RetrieveNumbers("8+");
        }
    }
}
