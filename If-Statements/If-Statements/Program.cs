using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if(numTemp == 20)
            {
                Console.WriteLine("It's suitable for pants and a pullover");
            }

            if(numTemp > 20)
            {
                Console.WriteLine("Shorts would be ideal for a day like this");

            }

            Console.Read();
        }
    }
}
