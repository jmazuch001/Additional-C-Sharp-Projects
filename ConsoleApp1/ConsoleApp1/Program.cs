using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument, called from a method, & waiting to happen");
            Console.Read();
        }
        // Access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }
}
