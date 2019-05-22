using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = -1; counter < 40; counter+=2)
            {
                Console.WriteLine(counter);
                // or Console.WriteLine(counter + " is lower than #");
            }
            Console.WriteLine("For loop is now finished");
            Console.Read();
        }
    }
}


// special notes: 
// If you want to incriment by 5's
// for(int counter = 0; counter < number high enough to do so; counter +=5) 
// {
//      Console.WriteLine(counter);
// } ...........