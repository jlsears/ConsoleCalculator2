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
        // Making static so dictionary can be accessed globally
        public Dictionary<string, string> ConstHolder = new Dictionary<string, string>();

        // Making void because we don't really need to return a dictionary when adding key value pair
        public void SettingConstant(string firstNumb, int secNumb)
        {
            string secStr = secNumb.ToString();
            ConstHolder.Add(firstNumb, secStr);
            //Console.Write("For real");
            return;
        }

        public static string FoundValue;
        public string NotFound = "Value not found";

        // Retrieving value from dictionary
        public string RetrievingConstant(string firstNumb)
        {
            if (ConstHolder.TryGetValue(firstNumb, out FoundValue))
            {
                return FoundValue;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
