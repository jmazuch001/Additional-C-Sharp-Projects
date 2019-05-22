using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statements
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

           

            // check to see if user is registered
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Welcome, registered user!");
                // if user name is empty, we write his username 
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    // checks to see if the username is Admin or not
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            Console.Read();
        }
    }
}
