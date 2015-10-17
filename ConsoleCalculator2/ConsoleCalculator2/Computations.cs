using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{   // Static because only want to use these methods as utilities (methods need to be static, too)
    public static class Computations
    {   // No one outside needs access to this
        private static int Answer;

        public static int Addition(int firstNumb, int secNumb)
        {
            Answer = firstNumb + secNumb;
            return Answer;
        }

        public static int Subtraction(int firstNumb, int secNumb)
        {
            Answer = firstNumb - secNumb;
            return Answer;
        }

        public static int Multiplication(int firstNumb, int secNumb)
        {
            Answer = firstNumb * secNumb;
            return Answer;
        }

        public static int Division(int firstNumb, int secNumb)
        {
            Answer = firstNumb / secNumb;
            return Answer;
        }

        public static int Modulo(int firstNumb, int secNumb)
        {
            Answer = firstNumb % secNumb;
            return Answer;
        }
    }
}
