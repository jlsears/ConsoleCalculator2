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

        Dictionary<char, string> constHolder = new Dictionary<char, string>();


        //public static dynamic SettingConstant(char firstNumb, int secNumb)
        //{
        //    //string firstStr = firstNumb.ToString();
        //    string secStr = secNumb.ToString();
        //    constHolder.Add(firstNumb, secStr);
        //    return;
        //}

    }
}
