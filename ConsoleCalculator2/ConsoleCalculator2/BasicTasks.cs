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
        public char ifChar;
        

        public void DelineateTerms(string expression)
        {
            var theDelimiters = new[] { '+', '-', '*', '/', '%', '=' }; 
            string desiredCalc = expression;

            string[] parsedInfo = desiredCalc.Split(theDelimiters);

            string firstPart = "filler";
            string secondPart = "filler";

            foreach (string s in parsedInfo)
            {
                // Is more than one delimiter present?
                if (s.Count() == 1)
                {
                    // Possibly use regex here?
                    int i = 0;
                    int j = 0;
                    //string s = "108";
                    bool result = int.TryParse(parsedInfo[0], out i); // If is is false, it's a constant
                    bool result2 = int.TryParse(parsedInfo[1], out j); // If j is false, it's a constant

                    if(i == 0)
                    {
                        Stack anotherStack = new Stack();
                        firstPart = anotherStack.RetrievingConstant(Convert.ToChar(parsedInfo[0]));
                    } else
                    {
                        firstPart = parsedInfo[0];

                    }

                    if (j == 0)
                    {
                        Stack nextStack = new Stack();
                        secondPart = nextStack.RetrievingConstant(Convert.ToChar(parsedInfo[1]));
                    } else
                    {
                        secondPart = parsedInfo[1];

                    }

                }
                else
                {
                    throw new ArgumentException();
                }

            }

            // Here's where we isolate our delimeter
            var foundIt = desiredCalc.IndexOfAny(theDelimiters);
            OurDelimeter = desiredCalc[foundIt];

            if (OurDelimeter == '=')
            {
                // Here we convert firstPart to char if we'll be setting a constant
                ifChar = Convert.ToChar(firstPart);
                secNumb = Convert.ToInt32(secondPart);
            }

            else
            {
                // Insert step to retrieve value from dictionary if one of these is a character here
                // So find out if either of these elements is a letter instead of a number
                //if()




                // Here are the final numbers we are looking to retrieve if performing computation
                firstNumb = Convert.ToInt32(firstPart);
                secNumb = Convert.ToInt32(secondPart);
            }

        }
        
    }
}
