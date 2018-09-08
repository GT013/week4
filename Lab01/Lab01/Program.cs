using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x, y,s;
            a = 10;
            b = 20;
            x = 5;
            y = 2;

            s = a + b;
            Console.WriteLine("Sum1 = {0}",s);
            s = x - b;
            Console.WriteLine("Sum2 = {0}",s);
            s = x * b;
            Console.WriteLine("Sum3 = {0}", s);
            s = y /a;
            Console.WriteLine("Sum4 = {0}", s);
            s = b % y;
            Console.WriteLine("Sum5 = {0}", s);
            s = (y + 10)%x;
            Console.WriteLine("Sum6 = {0}", s);
            s = (a/3) * 5;
            Console.WriteLine("Sum7 = {0}", s);
            s = (9/2) * a;
            Console.WriteLine("Sum8 = {0}", s);
            s = y % 8;
            Console.WriteLine("Sum9 = {0}", s);
            s = (100 * x) + (y % 2) - a;
            Console.WriteLine("Sum10 = {0}", s);
        }
    }
}
