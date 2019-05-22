using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_System_Playground
{
    class Program
    {
        // these are global variables
        // we need to use them across multiple METHODS
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
            // we want to have this static and use all of this section for registration only
        {
            Console.WriteLine("Please enter your username.");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password.");
            password = Console.ReadLine();
            Console.WriteLine("Registration is complete.");
            Console.WriteLine("--------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username.");
                if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your passowrd.");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed. Password is incorrect. Restart program.");
                }
            }
            else
            {
                Console.WriteLine("Login failed. Incorrect username. Restart the program.");
            }
        }
    }
}
