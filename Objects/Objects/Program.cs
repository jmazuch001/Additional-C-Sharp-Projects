using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is how to create an object of a class
            // an instance of human 
            Human joseph = new Human();
            // access public variable from outside, and even change it
            joseph.firstName = "Joseph";
            joseph.lastName = "Mazuch";
            // call methods of the class
            joseph.IntroduceMyself();



            Human michael = new Human();
            michael.firstName = "Jason"; // making a specific change
            michael.lastName = "Khan";
            michael.IntroduceMyself();
            Console.ReadKey();
        }
    }
}
