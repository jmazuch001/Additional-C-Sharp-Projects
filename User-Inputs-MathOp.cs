using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will allow a user to input data into the console
            // string input = Console.ReadLine(); // good for one user input per line of code
            // Console.WriteLine(input);
            // Console.Read();

            // Takes the user input, writes it to the console, and reads it --> END PROGRAM

            
            
            
            // challenge: Write a program that takes an input from a user and performs a 
            // mathematical operation

            // Approach 1
            //Console.WriteLine(Calculate());
            //Console.Read(); 
        }
        // public static int Calculate()
        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            

            Console.WriteLine(result);
        }

    }
}
