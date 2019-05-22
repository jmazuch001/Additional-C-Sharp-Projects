using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            // one way to add is to use int, create a variable, and use the method
            // int result = Add(12, 77);
            // Console.WriteLine(result);
            // Console.Read();

            // another way to add is to use an int and encapsulate the numbers to be addeed
            // Console.WriteLine(Add(15, 77));
            // Console.Read();

            // can also do this with the Add method: 
            //Console.WriteLine(Add(Add(1, 4), Add(2, 9)));
            //Console.WriteLine(Add(12, 22));
            //Console.Read();



            // multiplication 
            //int num1 = 4;
            //int num2 = 2;
            //Console.WriteLine(num1*num2);
            //Console.Read();

            Console.WriteLine(Divide(22, 33));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // we make a public void
        public static double Divide(double num1, double  num2)
        {
            return num1 / num2;
        }
    }
}
