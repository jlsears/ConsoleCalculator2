using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string prompt = "[" + counter + "]" + "> ";
            int firstNumb;
            int secNumb;

            // Take the user's input expression and save it to a variable
            Console.Write(prompt);
            string expression = Console.ReadLine();
            Evaluate.EvaluateThis(expression);
        }
    }
}
