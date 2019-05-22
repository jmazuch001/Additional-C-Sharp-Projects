using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter ++)
            {
                
                if (counter == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    //break; // will get out of the for loop
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();

        }

    }
}
