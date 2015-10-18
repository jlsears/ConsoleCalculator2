using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public static class Evaluate
    {
        public static int EvaluateThis(string expression)
        {
            // If statement for "lastq" will go here

            // Pass that variable into the method to parse out elements
            BasicTasks basicOperation = new BasicTasks();
            basicOperation.DelineateTerms(expression);

            // Pass those elements here to determine which calculation needs to be perfomed and get the answer
            // And be sure to include corresponding class name with property we're passing along
            switch (basicOperation.ourDelimeter)
            {
                case '+':
                    //counter = counter + 1;
                    return Computations.Addition(basicOperation.firstNumb, basicOperation.secNumb);
                case '-':
                    //counter = counter + 1;
                    return Computations.Subtraction(basicOperation.firstNumb, basicOperation.secNumb);
                case '*':
                    //counter = counter + 1;
                    return Computations.Multiplication(basicOperation.firstNumb, basicOperation.secNumb);
                case '/':
                    //counter = counter + 1;
                    return Computations.Division(basicOperation.firstNumb, basicOperation.secNumb);
                case '%':
                    //counter = counter + 1;
                    return Computations.Modulo(basicOperation.firstNumb, basicOperation.secNumb);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
