using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of data entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average.");

                input = Console.ReadLine();
                if(input.Equals("-1"))
                {
                    Console.WriteLine("---------------------------------------");
                    // calculate the average and let the teacher know
                    // we use a double to get the full number
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total = total + currentNumber;
                }
                else
                {
                    // if the number is higher than 20
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                // increase the amount of interations
                count++;
            }
            Console.ReadLine();
        }
    }
}
