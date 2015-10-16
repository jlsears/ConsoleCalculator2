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
            BasicTasks doSomething = new BasicTasks();
            doSomething.RetrieveNumbers("8+");
        }

        [TestMethod]
        public void CanAddSuccessfully()
        {
            Computations mathy = new Computations();
            mathy.Addition(8,2);
            Assert.AreEqual(mathy.Answer, 10);
        }

        [TestMethod]
        public void CanSubtractSuccessfully()
        {
            Computations mathy = new Computations();
            mathy.Subtraction(8, 2);
            Assert.AreEqual(mathy.Answer, 6);
        }

        [TestMethod]
        public void CanMultiplySuccessfully()
        {
            Computations mathy = new Computations();
            mathy.Multiplication(5, 3);
            Assert.AreEqual(mathy.Answer, 15);
        }

        [TestMethod]
        public void CanDivideSuccessfully()
        {
            Computations mathy = new Computations();
            mathy.Division(18, 3);
            Assert.AreEqual(mathy.Answer, 6);
        }

        [TestMethod]
        public void CanModuloSuccessfully()
        {
            Computations mathy = new Computations();
            mathy.Modulo(9, 2);
            Assert.AreEqual(mathy.Answer, 1);
        }
    }
}
