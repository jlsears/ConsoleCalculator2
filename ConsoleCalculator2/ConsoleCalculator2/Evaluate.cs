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
            BasicTasks basicOperation = new BasicTasks();

            // Pass that variable into the method to parse out elements
            BasicTasks doMath = new BasicTasks();
            doMath.DelineateTerms(expression);

            // Pass those elements here to determine which calculation needs to be perfomed and get the answer
            // And be sure to include corresponding class name with property we're passing along
            switch (doMath.OurDelimeter)
            {
                case '+':
                    //counter = counter + 1;
                    return Computations.Addition(doMath.firstNumb, doMath.secNumb);
                case '-':
                    //counter = counter + 1;
                    return Computations.Subtraction(doMath.firstNumb, doMath.secNumb);
                case '*':
                    //counter = counter + 1;
                    return Computations.Multiplication(doMath.firstNumb, doMath.secNumb);
                case '/':
                    //counter = counter + 1;
                    return Computations.Division(doMath.firstNumb, doMath.secNumb);
                case '%':
                    //counter = counter + 1;
                    return Computations.Modulo(doMath.firstNumb, doMath.secNumb);
                // Need to include case for equal sign to set constant here
                //case '=':
                //    return Stack.SettingConstant(basicOperation.ifChar, basicOperation.secNumb);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
