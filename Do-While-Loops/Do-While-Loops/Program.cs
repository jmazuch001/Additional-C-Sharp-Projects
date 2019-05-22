using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine(); // what is the entry the user gives us
                int currentLength = nameOfFriend.Length; // check the length of the text
                // this is added to the length of the current integer (int lengthOfText)
                lengthOfText += currentLength;
                wholeText += nameOfFriend;


            } while (lengthOfText < 50); // we only want to have max of 50 characters
            Console.WriteLine("Thanks. That was plenty. " + wholeText); // will fire when 50 chars has been hit
            Console.Read();
        }
    }
}
