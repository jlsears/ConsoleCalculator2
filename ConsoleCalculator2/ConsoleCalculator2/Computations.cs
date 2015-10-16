using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public class Computations
    {
        public int Answer;

        public int Addition(int firstNumb, int secNumb)
        {
            Answer = firstNumb + secNumb;
            return Answer;
        }

        public int Subtraction(int firstNumb, int secNumb)
        {
            Answer = firstNumb - secNumb;
            return Answer;
        }

        public int Multiplication(int firstNumb, int secNumb)
        {
            Answer = firstNumb * secNumb;
            return Answer;
        }

        public int Division(int firstNumb, int secNumb)
        {
            Answer = firstNumb / secNumb;
            return Answer;
        }

        public int Modulo(int firstNumb, int secNumb)
        {
            Answer = firstNumb % secNumb;
            return Answer;
        }
    }
}
