using System;
using System.Collections.Generic;
using System.Text;

namespace day8
{
    class parent3
    {
        public void CheckLength(int a, int b, int c, int d, int m, int n, int o, int p)
        {
            double length1 = Math.Sqrt((Math.Pow(c - a, 2) + Math.Pow(d - b, 2)));
            Console.WriteLine("the length of the line1 is" + length1);
            double length2 = Math.Sqrt((Math.Pow(o - m, 2) + Math.Pow(p - n, 2)));
            Console.WriteLine("the length of the line2 is" + length2);
            if (length1 == length2)
            {
                Console.WriteLine("both lines are equal");
            }
            else
            {
                Console.WriteLine("both lines are not equal");
            }
        }
    }
}
