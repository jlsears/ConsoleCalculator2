using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator2;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        // Evaluate Tests

        private Evaluate evaluations;
        private Stack stacking;

        [TestInitialize]
        public void Initialize()
        {
            evaluations = new Evaluate();
            stacking = new Stack();

        }

        [TestMethod]
        public void CanReachCorrectAnswersFromInitialInputExpression()
        {
            Assert.AreEqual(evaluations.EvaluateThis("8+2"), 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForIncorrectEvaluationExpression()
        {
            evaluations.EvaluateThis("8+");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForAnotherIncorrectEvaluationExpression()
        {
            evaluations.EvaluateThis("/8");
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
            stacking.SettingConstant("x", 5);
            Assert.IsTrue(stacking.ConstHolder.ContainsKey("x"));
            Assert.IsTrue(stacking.ConstHolder.ContainsValue("5"));
        }

        [TestMethod]
        public void CanSuccessfullyRetrieveConstantsFromDictionary()
        {
            stacking.SettingConstant("y", 4);
            string firstNumb = "y";
            string expected = "4";
            string actual = stacking.RetrievingConstant(firstNumb);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForNotFoundValue()
        {
            stacking.RetrievingConstant("y");
        }
    }
}
