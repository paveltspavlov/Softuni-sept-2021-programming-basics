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
                result2 = Math.Floor(distance / 15);
                intermedeateTime = distance * timeInSeconds;
                Math.Round(intermedeateTime, mode: MidpointRounding.AwayFromZero);
                result = intermedeateTime + (result2 * 12.5);
                //result = timeInSeconds * distance;

=======
            
            if (distance > 14)
            {
                result2 = distance / 15;
                intermedeateTime = distance *timeInSeconds;
                
                result = intermedeateTime + (result2 * 12.5);
                //result = timeInSeconds * distance;
                Math.Round(result,2);
>>>>>>> 3480553fc8213acf483950cf375263ba3993010c
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
<<<<<<< HEAD
                //output = Math.Floor(result - worldRecord);
=======
>>>>>>> 3480553fc8213acf483950cf375263ba3993010c
                output = result - worldRecord;
                Console.WriteLine($"No, he failed! He was {output:f2} seconds slower.");
            }
        }
    }
}
 