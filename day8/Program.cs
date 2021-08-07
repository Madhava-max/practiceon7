using System;

namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give the value of x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of y2");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of x3");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of y3");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of x4");
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("give the value of y4");
            int y4 = int.Parse(Console.ReadLine());
            //1st problem
            //parent p = new parent();
            //p.FindTheLength(x1, y1, x2, y2);

            //3rd problem
            //parent2 p = new parent2();
            //p.CheckLength(x1, y1, x2, y2, x3, y3, x4, y4);
            //uc2
            //parent3 p = new parent3();
            //p.CheckLength(x1, y1, x2, y2, x3, y3, x4, y4);

            //uc4
            parent4 p = new parent4();
          double length1=  p.Length(x1, y1, x2, y2);
            double length2 = p.Length(x3, y3, x4, y4);
            if(length1>length2)
            {
                Console.WriteLine("line1 is bigger");
            }
            else if (length2 > length1)
            {
                Console.WriteLine("line2 is bigger");
            }
           else
            {
                Console.WriteLine("both are equal");
            }

        }
    }
}
