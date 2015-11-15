using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{   // not static because we're going to instantiate an instance of this in Evaluate
    public class BasicTasks
    {
        public int firstNumb;
        public int secNumb;
        public char OurDelimeter;
        public string ifChar;
        public Stack calcStack { get; set; }

        public BasicTasks()
        {
            calcStack = new Stack();

        }

        public void DelineateTerms(string expression)
        {
            var theDelimiters = new[] { '+', '-', '*', '/', '%', '=' };
            string desiredCalc = expression;

            string[] parsedInfo = desiredCalc.Split(theDelimiters);

            string firstPart = "filler";
            string secondPart = "filler";

            // Here's where we isolate our delimeter
            var foundIt = desiredCalc.IndexOfAny(theDelimiters);
            OurDelimeter = desiredCalc[foundIt];
            firstPart = parsedInfo[0];
            secondPart = parsedInfo[1];

            // To handle setting letters as constants
            if (OurDelimeter == '=')
            {
                // Here we convert firstPart to char if we'll be setting a constant
                ifChar = firstPart;
                secNumb = Convert.ToInt32(secondPart);
                return;
            }

            // If we'll be performing a computation
            else
            {
                int i = 0;
                bool result = int.TryParse(parsedInfo[0], out i); //i will be false if char
                if (i == 0)
                {
                    //Retrieve the constant's value from the dictionary
                    string grabValue = firstPart;
                    //Stack secondStack = new Stack();
                    string gotValue = calcStack.RetrievingConstant(grabValue);
                    firstNumb = Convert.ToInt32(gotValue);

                } else
                {
                    firstNumb = Convert.ToInt32(parsedInfo[0]);
                }

                int j = 0;
                bool result2 = int.TryParse(parsedInfo[1], out j); //j will be false if char
                if (j == 0)
                {
                    //Retrieve the constant's value from the dictionary
                    string nextValue = secondPart;
                    //Stack secondStack = new Stack();
                    string foundValue = calcStack.RetrievingConstant(nextValue);
                    secNumb = Convert.ToInt32(foundValue);
                }
                else
                {
                    secNumb = Convert.ToInt32(parsedInfo[1]);
                }
            }
        }
    }
}