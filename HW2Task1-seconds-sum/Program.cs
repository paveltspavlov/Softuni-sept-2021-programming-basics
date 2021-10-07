using System;

namespace HW2Task1_seconds_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutesSum = totalTime / 60;
            int secondsSum = totalTime % 60;

            if (secondsSum < 10)
            {
                Console.WriteLine($"{minutesSum}:0{secondsSum}");
            }
            else {
                Console.WriteLine($"{minutesSum}:{secondsSum}");
            }
        }
    }
}
