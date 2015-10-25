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
                    // Here's where we isolate our delimeter
                    var foundIt = desiredCalc.IndexOfAny(theDelimiters);
                    OurDelimeter = desiredCalc[foundIt];
                    firstPart = parsedInfo[0];
                    secondPart = parsedInfo[1];

                    // To handle setting letters as constants
                    if (OurDelimeter == '=')
                    {
                        // Here we convert firstPart to char if we'll be setting a constant
                        ifChar = Convert.ToChar(parsedInfo[0]);
                        secNumb = Convert.ToInt32(secondPart);
                    }

                    else
                    {
                        int i = 0;
                        bool result = int.TryParse(parsedInfo[0], out i); //i will be false if char
                        if (i == 0)
                        {
                            //Retrieve the constant's value from the dictionary
                            char grabValue = Convert.ToChar(parsedInfo[0]);
                            Stack secondStack = new Stack();
                            string foundValue = secondStack.RetrievingConstant(grabValue);

                            firstNumb = Convert.ToInt32(foundValue);
                            secNumb = Convert.ToInt32(parsedInfo[1]);
                            break;

                        }

                        // Here are the final numbers we are looking to retrieve if performing computation 
                        firstNumb = Convert.ToInt32(firstPart);
                        secNumb = Convert.ToInt32(secondPart);
                    }

                }
                else
                {   // Throwing error if more than on delimeter is present
                    throw new ArgumentException();
                }

            }



        }
        
    }
}
