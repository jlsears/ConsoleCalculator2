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
            var propeller = true;

            while (propeller) {

                string prompt = "[" + counter + "]" + "> ";

                // Take the user's input expression and save it to a variable
                Console.Write(prompt);
                string expression = Console.ReadLine();

                switch (expression)
                {
                    //Hhandling one keyword for exiting application
                    case "quit":
                        Console.WriteLine("See ya!");
                        Environment.Exit(1);
                        return;

                    // Handling another keyword for exiting the application
                    case "exit":
                        Console.WriteLine("See ya!");
                        Environment.Exit(1);
                        return;

                    // Handling the user entering "last" command
                    case "last":
                        Console.WriteLine(Stack.lastAnswer);
                        break;

                    // Handling the user entering "lastq" command
                    case "lastq":
                        Console.WriteLine(Stack.LastCommand);
                        break;

                    // Handling the user entering an expression to be evaluated
                    default:
                        counter = counter + 1;

                        // Stashing this away so it's ready if user enters "lastq" command
                        if (expression != "lastq" || expression != "last")
                        {
                            Stack.LastCommand = expression;
                            //return; P.S. This nefarious return was what interfered with looping back to prompt again
                        }

                        Evaluate.EvaluateThis(expression);
                        Console.WriteLine("= " + Computations.Answer);
                        break;
                }
                
            }
        }
    }
}
