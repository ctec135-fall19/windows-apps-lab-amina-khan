﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating new object
            MyClass mc = new MyClass(123);


            // method call
            mc.printState();
        }
    }
}
