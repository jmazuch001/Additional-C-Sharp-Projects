using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            // TryParse - whatever you want to try to parse - literally 
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number. 0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Don't even think about wearing shorts, today");
            } else if (numTemp == 20)
            {
                Console.WriteLine("Might want to add a coat to your layers");
            } else if (numTemp > 30)
            {
                Console.WriteLine("Still not quite ready for wearing shorts");
            } else
            {
                Console.WriteLine("Shorts would be a good plan for today");
            }
                
            
            

            Console.Read();
        }
    }
}
