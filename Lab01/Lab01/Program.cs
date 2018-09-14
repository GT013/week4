using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {

            for (float i = -8; i <= 8; i += 0.5F) //หาค่า 0.5
            {
                Console.WriteLine(spaces(i * i) + "*");
            }
        }
        private static string spaces(double val)
        {
            if (val < -10) return ("");
            string SpaceString = new String(' ', ((int)(val) + 10)); //ระยะห่าง
            return SpaceString;

        }

    }
}
