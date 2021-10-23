using System;

namespace HW2Task7_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double videoCards = N * 250;
            double processor = videoCards * 0.35;
            double memory = videoCards * 0.1;
            double totalProcessors = processor * M;
            double totalMem = memory * P;
            double totalPrice;

            if (N > M)
            {
                totalPrice = (videoCards + totalProcessors + totalMem) * 0.85;
            }
            else 
            {
                totalPrice = videoCards + totalProcessors + totalMem;
            }

            if (budget > totalPrice)
            {
                double change = budget - totalPrice;
                Console.WriteLine($"You have {change:f2} leva left!");
            }
            else 
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
            }

        }
    }
}