using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class MyClass
    {
        
        // constructor
        public MyClass(int x)
        {
            this.myField = x;
        }

        // method to print field
        public void printState()
        {
            Console.WriteLine("State: {0}", myField);
        }
    }
}
