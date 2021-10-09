using System;

namespace HW2Task3_time_plus_15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int resultMinutes = minutes + 15;

            if (resultMinutes >= 60)
            {
                hour++;
                minutes = resultMinutes - 60;
            } else if (resultMinutes<60) 
            {
                minutes = resultMinutes;
            } else if (resultMinutes<59) 
            {
                minutes = + resultMinutes;
            }

            if (hour > 23) {
                hour = 0;
            };

            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
