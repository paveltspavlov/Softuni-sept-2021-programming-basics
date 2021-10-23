using System;

namespace HW2Task6_worldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double intermedeateTime;
            double result;
            double result2;
            double output;
<<<<<<< HEAD

            if (distance > 14)
            {
                timeInSeconds = timeInSeconds + (intermedeateTime * 12.5);
                result = timeInSeconds * distance;
            }
            else
            {
                result = timeInSeconds * distance;
                Math.Round(result,2);
            }
            if (result < worldRecord)
            {
                //output = Math.Floor(result);
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:f2} seconds.");
            }
            else
            {
                output = worldRecord - result;
                Console.WriteLine($"No, he failed! He was {output:f2} seconds slower.");
            }
        }
    }
}
 