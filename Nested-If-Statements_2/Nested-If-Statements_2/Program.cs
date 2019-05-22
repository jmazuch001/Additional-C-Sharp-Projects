using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username");

            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin");
            }

            // with the || it means either / or - one of them has to be true
            // if neither one is true, then the statement is false
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }
    }
}
