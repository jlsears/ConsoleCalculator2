using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator2
{
    public class Stack
    {
        public static int lastAnswer { get; set; }

        private static string lastCommand = "Whatchoo talkin' 'bout, Willis?";
        

        public static string LastCommand
        {
            get { return lastCommand; }

            set { lastCommand = value; }
        }
    }
}
