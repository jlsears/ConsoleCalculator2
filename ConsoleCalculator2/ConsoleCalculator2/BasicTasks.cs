﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public class BasicTasks
    {
        public int firstNumb = 0;
        public int secNumb = 0;

        public void RetrieveNumbers(string expression)
        {
            var theDelimiters = new[] { '+', '-', '*', '/', '%' };
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

            // Here are the final numbers we are looking to retrieve
            firstNumb = Convert.ToInt32(firstPart);
            secNumb = Convert.ToInt32(secondPart);
        }
    }
}
