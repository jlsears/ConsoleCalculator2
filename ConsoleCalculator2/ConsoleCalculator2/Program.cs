using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var propeller = true;
            BasicTasks basicOperation = new BasicTasks();


            while (propeller) {

                string prompt = "[" + counter + "]" + "> ";

                // Take the user's input expression and save it to a variable
                Console.Write(prompt);
                string expression = Console.ReadLine();

                switch (expression)
                {
                    //Handling one keyword for exiting application
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
                        Console.WriteLine(Stack.LastAnswer);
                        break;

                    // Handling the user entering "lastq" command
                    case "lastq":
                        Console.WriteLine(Stack.LastCommand);
                        break;

                    // Handling the user entering an expression to be evaluated
                    default:

                        // Increment counter with each go round
                        // counter = counter + 1;

                        // Stashing this away so it's ready if user enters "lastq" command
                        if (expression != "lastq" || expression != "last")
                        {
                            Stack.LastCommand = expression;
                        }

                        // Going to find our delimeter
                        basicOperation.DelineateTerms(expression);
                        Evaluate evaluating = new Evaluate(basicOperation);

                        //Stack MainStack = new Stack();

                        // Here we determine whether to send this on for calculation or constant setting
                        switch (basicOperation.OurDelimeter) 
                        {
                            // Will get set as a constant
                            case '=':
                                basicOperation.calcStack.SettingConstant(basicOperation.ifChar, basicOperation.secNumb);
                                //Console.WriteLine("the expression " + expression + " has been added to the dictionary");
                                break;
                            
                            default:
                                evaluating.EvaluateThis(expression);

                                // Increment counter with each go round
                                counter = counter + 1;

                                //MainStack.RetrievingConstant();
                                Console.WriteLine("= " + Computations.Answer);
                                break;
                        }
                        break;
                }               
            }
        }
    }
}
