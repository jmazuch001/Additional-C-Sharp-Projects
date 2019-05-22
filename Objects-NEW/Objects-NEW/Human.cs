using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_NEW
{
    // this class is a bluepring for a datatype
    class Human
    {
        // members
        // member variables
        private string firstName = "Michael";
        

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0}", firstName);
        }
    }
}
