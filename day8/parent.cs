using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
     class parent
    {
        public void FindTheLength(int a,int b,int c,int d)
        {
            double length = Math.Sqrt((Math.Pow(c - a, 2) + Math.Pow(d-b, 2)));
            Console.WriteLine("the length of the line is" + length);
        }
    }
}
