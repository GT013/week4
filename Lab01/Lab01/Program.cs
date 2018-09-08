using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            const double kmToau = 0.000000006685;
            const double kmTomile = 0.621371192;
            const double lightSpeed = 186000d;   // miles per second
            double lighttime, sunto,dis,sum;
            char k;
            do
            {
               
                Console.Write("\nPlease Distance KM = ");
                dis = double.Parse(Console.ReadLine());
                sum = dis * kmToau;
                Console.WriteLine("DistanceToSun = {0:F2} A.U", sum);
                sunto = dis * kmTomile;
                Console.WriteLine("DistanceMile = {0:F2} Mile", sunto);
                lighttime = sunto / lightSpeed;
                Console.WriteLine("LightSpeedTime = {0:F2} Minutes", lighttime / 60);

                k = Console.ReadKey().KeyChar;
            }
            while ((k=='Y')||(k == 'y'));
        }
    }
}
