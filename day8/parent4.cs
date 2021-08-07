using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class parent4
    {
        public double Length(int a, int b, int c, int d)
        {
            double length = Math.Sqrt((Math.Pow(c - a, 2) + Math.Pow(d - b, 2)));
            Console.WriteLine("the length of the line1 is" + length);
            return length;
            
        }
        //public double Length2(int m, int n, int o, int p)
        //{
        //    double length2 = Math.Sqrt((Math.Pow(o - m, 2) + Math.Pow(p - n, 2)));
        //    Console.WriteLine("the length of the line1 is" + length2);
        //    return length2;

        //}

    }
}
