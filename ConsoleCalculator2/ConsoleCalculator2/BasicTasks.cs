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
                    firstPart = parsedInfo[0];
                    secondPart = parsedInfo[1];
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
                // Here are the final numbers we are looking to retrieve if performing computation
                firstNumb = Convert.ToInt32(firstPart);
                secNumb = Convert.ToInt32(secondPart);
            }

        }
        
    }
}
