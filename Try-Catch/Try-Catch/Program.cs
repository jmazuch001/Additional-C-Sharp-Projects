using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a nubmer");
            string userInput = Console.ReadLine();

            int num1 = 7;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                // throw;

                Console.WriteLine("Cannot divide by zero!");
            }

            // shortcut: type "try" and hit tab twice to autofill 
            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (FormatException)
            {

               // throw;

                Console.WriteLine("Format exception, please enter the correct type next time.");
                // you can input a correct or incorrect value
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
                // when you input values that are either too large or small in quantity, such as: 
                // 07132948590123749875192739471982739471923848192379408719283749817234
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Overflow exception, the value was empty (null)");
                // 
            }
            finally
            {
                Console.WriteLine("This is called, anyway!");
                // this is a means of ending code
                // This is how you can close the connection to the internet - with a finally block
            }


            Console.ReadKey();
        }
    }
}
