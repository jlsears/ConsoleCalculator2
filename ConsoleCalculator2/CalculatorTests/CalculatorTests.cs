using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator2;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        // Evaluate Tests

        [TestMethod]
        public void CanReachCorrectAnswersFromInitialInputExpression()
        {
            Assert.AreEqual(Evaluate.EvaluateThis("8+2"), 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForIncorrectEvaluationExpression()
        {
            Evaluate.EvaluateThis("8+");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForAnotherIncorrectEvaluationExpression()
        {
            Evaluate.EvaluateThis("/8");
        }

        // Parsing Tests

        [TestMethod]
        public void CanParseTermsFromGOOD2TermExpression()
        {
            BasicTasks doSomething = new BasicTasks();
            doSomething.DelineateTerms("8+2");
            Assert.AreEqual(doSomething.firstNumb, 8);
            Assert.AreEqual(doSomething.secNumb, 2);
            Assert.AreEqual(doSomething.OurDelimeter, '+');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForIncorrectExpression()
        {
            BasicTasks doSomething = new BasicTasks();
            doSomething.DelineateTerms("8+");
        }

        // Good Expressions

        [TestMethod]
        public void CanAddSuccessfully()
        {
            Assert.AreEqual(Computations.Addition(8, 2), 10);
        }

        [TestMethod]
        public void CanSubtractSuccessfully()
        {
            Assert.AreEqual(Computations.Subtraction(8, 2), 6);
        }

        [TestMethod]
        public void CanMultiplySuccessfully()
        {
            Assert.AreEqual(Computations.Multiplication(5, 3), 15);
        }

        [TestMethod]
        public void CanDivideSuccessfully()
        {
            Assert.AreEqual(Computations.Division(12, 2), 6);
        }

        [TestMethod]
        public void CanModuloSuccessfully()
        {
            Assert.AreEqual(Computations.Modulo(9, 2), 1);
        }

        [TestMethod]
        public void PeopleUsingCalculatorWithSuccessiveCalls()
        {
            Assert.AreEqual(Computations.Division(12, 2), 6);
            Assert.AreEqual(Computations.Modulo(9, 2), 1);

        }

        // Dictionary Tests

        [TestMethod]
        public void CanSuccessfullyAddConstantsToDictionary()
        {
            Stack testStack = new Stack();
            testStack.SettingConstant('x', 5);
            Assert.IsTrue(testStack.ConstHolder.ContainsKey('x'));
            Assert.IsTrue(testStack.ConstHolder.ContainsValue("5"));
        }

        [TestMethod]
        public void CanSuccessfullyRetrieveConstantsFromDictionary()
        {
            Stack testStack = new Stack();
            testStack.SettingConstant('x', 5);
            char firstNumb = 'x';
            string expected = "5";
            string actual = testStack.RetrievingConstant(firstNumb);
            Assert.AreEqual(expected, actual);
        }
    }
}
