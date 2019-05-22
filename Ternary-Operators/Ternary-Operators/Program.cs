using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // how it works:
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // the conditional operator is right - associative. 
            // the expression a / b: c ? d : e 
            // is evaluated as a ? b : (c ? d : e), 
            // not as (a? b : c) ? d:e. 
            // The conditional operator cannot be overloaded.


            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else if (temperature > 100)
                stateOfMatter = "gas";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 100;
            

            // in short, here is the enhanced if statement of what is above: 
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}
