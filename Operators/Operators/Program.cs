using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3 );

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // increment operators 
            int num = 0;
            num++;
            Console.WriteLine("num3 is {0}", num);
            Console.WriteLine("num3 is {0}", num++); // incrementing happens after the variable
            // pre increment
            Console.WriteLine("num3 is {0}", ++num); // incrementing happens before the variable


            // decrement operator
            num--;
            Console.WriteLine("num3 is {0}", num);
            Console.WriteLine("num3 is {0}", num--);
            // pre decrement
            Console.WriteLine("num3 is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);

            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);

            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);

            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);


            // relational and type operators
            bool isLower;
            isLower = num1 > num2;

            
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            
            Console.WriteLine("result of num1 == num2 is {0}", result);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);


            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower && isSunny {0}", isLowerAndSunny);

            // condition 1 or condition 2 has to be true
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result of isLower || isSunny {0}", isLowerAndSunny);

            Console.ReadKey();
        }
    }
}
