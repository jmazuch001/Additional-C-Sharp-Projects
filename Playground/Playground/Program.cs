using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num1input = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string num2input = Console.ReadLine();

            try
            {
                int num1 = int.Parse(num1input);
                int num2 = int.Parse(num2input);
                int answer = num1 / num2;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hey idiot enter just a number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too long I am not that smart!");
            }
            catch (Exception)
            {
                Console.WriteLine("Other error");
            }
            finally
            {
                int num1 = int.Parse(num1input);
                int num2 = int.Parse(num2input);
                int answer = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + answer);
            }
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
