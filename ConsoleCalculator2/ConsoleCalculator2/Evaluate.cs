﻿using System;
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
            // Isolate delimeter and numbers for calculation
            BasicTasks doMath = new BasicTasks();
            doMath.DelineateTerms(expression);

            // Determine if an element is a constant, and insert number value if so
            //if()

            // Pass those elements here to determine which calculation needs to be perfomed and get the answer
            switch (doMath.OurDelimeter)
            {
                case '+':
                    return Computations.Addition(doMath.firstNumb, doMath.secNumb);
                case '-':
                    return Computations.Subtraction(doMath.firstNumb, doMath.secNumb);
                case '*':
                    return Computations.Multiplication(doMath.firstNumb, doMath.secNumb);
                case '/':
                    return Computations.Division(doMath.firstNumb, doMath.secNumb);
                case '%':
                    return Computations.Modulo(doMath.firstNumb, doMath.secNumb);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
