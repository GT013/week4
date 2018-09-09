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
            Console.Write("Enter Number : ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(randomNumber);
            bool re = randomNumber == N;
            Console.WriteLine("{0}",re);
        }
    }
}
