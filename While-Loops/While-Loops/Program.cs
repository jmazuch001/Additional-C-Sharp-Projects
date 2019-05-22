using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // program that increments +1 each time you press "enter" key
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" 
                    + " + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} people have been accounted for. Press enter to close the program.");
            Console.Read();
        }

    }
}
