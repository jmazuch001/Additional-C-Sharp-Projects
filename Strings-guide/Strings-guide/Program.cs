using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_guide
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Joseph"; // standard is lowercase s in string

            string message = "My name is " + myname;

            // string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            // Console.WriteLine("My name is " + myname);
            Console.WriteLine(lowerCaseMessage);
            Console.Read();


        }
    }
}
