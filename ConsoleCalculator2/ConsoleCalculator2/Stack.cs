using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public class Stack
    {
        private static int lastanswer;

        public static int LastAnswer

        {
            get { return lastanswer; }

            set { lastanswer = value; }

        }

        private static string lastCommand = "Whatchoo talkin' 'bout, Willis?";

        public static string LastCommand
        {
            get { return lastCommand; }

            set { lastCommand = value; }
        }

        // Second argument needs to come in as an integer but get set as a string
        public Dictionary<char, string> ConstHolder = new Dictionary<char, string>();

        // Making void because we don't really need to return a dictionary
        public void SettingConstant(char firstNumb, int secNumb)
        {
            string secStr = secNumb.ToString();
            ConstHolder.Add(firstNumb, secStr);
            return;
        }

        public string FoundValue = "";
        public string NotFound = "Value not found";

        public string RetrievingConstant(char firstNumb)
        {
            if (ConstHolder.TryGetValue(firstNumb, out FoundValue))
            {
                return FoundValue;
            }
            else
            {
                Console.WriteLine(NotFound);
                return NotFound;
            }
        }

    }
}
