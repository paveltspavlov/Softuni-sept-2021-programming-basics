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
            double intermedeateTime = distance / 15;
            double result;
            double output;

            if (intermedeateTime > 14)
            {
                timeInSeconds = timeInSeconds + (intermedeateTime * 12.5);
                result = timeInSeconds * distance;
            }
            else 
            {
                result = timeInSeconds * distance;
            }

            if (result < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:f2} seconds");
            }
            else 
            {
                output = worldRecord - result;
                Console.WriteLine($"No, he failed! He was {output:f2} seconds slower.");
            }
        }
    }
}
