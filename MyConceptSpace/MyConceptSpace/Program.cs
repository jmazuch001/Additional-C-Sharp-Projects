using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConceptSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = Divide(33, 55);
            Console.WriteLine(Divide(25, 13));
            Console.Read();

        }
        // Access modifier (static) return type method name (param1, param2)
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

            



        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }



    }
    
}
