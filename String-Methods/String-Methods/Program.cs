using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Mary";
            string friend3 = "Joyce";

            // One way of doing this is:
            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);

            // Another approach would be: 
            GreetFriend(friend1, friend2, friend3);
            Console.Read();
        }

        // public static void GreetFriend(string friendName)
        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName + " , my friend!");
            Console.WriteLine("Hi " + friendName2 + " , my friend!");
            Console.WriteLine("Hi " + friendName3 + " , my friend!");
        }

    }
}