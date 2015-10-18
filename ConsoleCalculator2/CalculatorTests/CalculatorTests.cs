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

        // Last Commands

        //[TestMethod]
        //public void CanRetrieveLastGivenAnswer()
        //{
        //    Computations.Answer = 10;
        //    Assert.AreEqual(Stack.lastAnswer, Computations.Answer);
        //}

        //[TestMethod]
        //public void CanRetrieveLastCommand()
        //{
        //    BasicTasks recall = new BasicTasks();
        //    recall.firstNumb = 5;
        //    recall.secNumb = 2;
        //    recall.ourDelimeter = '+';
        //    string checkThis = recall.firstNumb.ToString() + recall.ourDelimeter.ToString() + recall.secNumb.ToString();
        //    Stack.lastCommand = "5+2";
        //    Assert.AreEqual(Stack.lastCommand, checkThis);
        //}


        // Parsing Tests

        [TestMethod]
        public void CanParseTermsFromGOOD2TermExpression()
        {
            BasicTasks doSomething = new BasicTasks();
            doSomething.DelineateTerms("8+2");
            Assert.AreEqual(doSomething.firstNumb, 8);
            Assert.AreEqual(doSomething.secNumb, 2);
            Assert.AreEqual(doSomething.ourDelimeter, '+');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsErrorForIncorrectExpression()
        {
            BasicTasks doSomething = new BasicTasks();
            doSomething.DelineateTerms("8+");
        }

        // Good Expressions

        //[TestMethod]
        //public void CanAddSuccessfully()
        //{
        //    Assert.AreEqual(Computations.Addition(8,2), 10);
        //}

        [TestMethod]
        public void CanSubtractSuccessfully()
        {
            Assert.AreEqual(Computations.Subtraction(8,2), 6);
        }

        [TestMethod]
        public void CanMultiplySuccessfully()
        {
            Assert.AreEqual(Computations.Multiplication(5,3), 15);
        }

        [TestMethod]
        public void CanDivideSuccessfully()
        {
            Assert.AreEqual(Computations.Division(12,2), 6);
        }

        [TestMethod]
        public void CanModuloSuccessfully()
        {
            Assert.AreEqual(Computations.Modulo(9,2), 1);
        }
    }
}
