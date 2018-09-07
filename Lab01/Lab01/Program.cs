using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Random random = new Random();
            int randomNumber = random.Next(0,9);
            Console.WriteLine("Enter Number :");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(randomNumber);
        }
    }
}
