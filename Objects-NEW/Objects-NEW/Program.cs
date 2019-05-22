using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // aka an instance of human
            Human joseph = new Human();
            // access public variable from outside, and even change it
            // in this case, I changed the variable name to "John"
            joseph.firstName = "John";
            // call methods of the class
            joseph.IntroduceMyself();

            Human michael = new Human();
            michael.firstName = "Mikel";
            michael.IntroduceMyself();

            Console.ReadKey();

        }
    }
}
