using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = Math.PI* -1.9F; i < Math.PI * 1.9F; i += 0.1F)
            {
                Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" +
                spaces(Math.Tan(i)) + "*", i, Math.Tan(i));
            }
        }
        private static string spaces(double val)
        {
            if (val < 0) return ("");
            string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
            return SpaceString;

        }

    }
}
