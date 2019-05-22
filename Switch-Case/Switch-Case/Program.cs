using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 29;

            switch (age)
            {
                case 19:
                    Console.WriteLine("Too young to party in the club!");
                    break; // if the switch was true, we need to be able to break out of the statement
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young bro");
            } else if (age == 25){
                Console.WriteLine("Good to go bro");
            } else
            {
                Console.WriteLine("How old are you, then?");
            }

            string username = "Joseph";

            switch (username)
            {
                case "Joseph":
                    Console.WriteLine("Username is Joseph");
                    break;

                case "root":
                    Console.WriteLine("Username is root");
                    break;
                        default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}
