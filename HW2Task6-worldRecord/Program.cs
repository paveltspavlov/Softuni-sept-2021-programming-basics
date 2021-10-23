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

            if (distance > 14)
            {
                result2 = Math.Floor(distance / 15);
                intermedeateTime = distance * timeInSeconds;
                Math.Round(intermedeateTime, mode: MidpointRounding.AwayFromZero);
                result = intermedeateTime + (result2 * 12.5);
                //result = timeInSeconds * distance;

            }
            else
            {
                result = timeInSeconds * distance;
            }
            if (result < worldRecord)
            {
                //output = Math.Floor(result);
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:f2} seconds.");
            }
            else
            {
                //output = Math.Floor(result - worldRecord);
                output = result - worldRecord;
                Console.WriteLine($"No, he failed! He was {output:f2} seconds slower.");
            }
        }
    }
}
