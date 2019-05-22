using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Human
    {
        // Members
        // Member variable
        public string firstName = "Joseph";
        public string lastName = "Mazuch";


        // public member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

    }
}
