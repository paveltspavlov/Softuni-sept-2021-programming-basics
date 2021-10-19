using System;

namespace HW2Task4_babyToysStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double finalPrice;
            double netRevenew;
            double rent;
            double discount;

            double tripPrice = double.Parse(Console.ReadLine());
            double orderedJigsawPuzzles = double.Parse(Console.ReadLine());
            double orderedTalkingDolls = double.Parse(Console.ReadLine());
            double orderedTeddyBears = double.Parse(Console.ReadLine());
            double orderedMinions = double.Parse(Console.ReadLine());
            double orderedTrucks = double.Parse(Console.ReadLine());

            double jigsawsPrice = 2.6 * orderedJigsawPuzzles;
            double dollsPrice = 3 * orderedTalkingDolls;
            double bearsPrice = 4.10 * orderedTeddyBears;
            double minionPrice = 8.20 * orderedMinions;
            double trucksPrice = 2 * orderedTrucks;

            double toysPriceTotal = jigsawsPrice+ dollsPrice+ bearsPrice+ minionPrice+ trucksPrice;

            double totalCountToys = orderedJigsawPuzzles+ orderedTalkingDolls+ orderedTeddyBears+ orderedMinions+ orderedTrucks;

            if (totalCountToys >= 50)
            {
                discount = toysPriceTotal * 0.25;
                finalPrice = toysPriceTotal - discount;

            }
            else 
            {
                finalPrice = toysPriceTotal;
            }

            rent = finalPrice * 0.1;

            netRevenew = finalPrice - rent;

            if (netRevenew >= tripPrice)
            {
                netRevenew = finalPrice - rent - tripPrice;
                Console.WriteLine($"Yes! {netRevenew:f2} lv left.");
            }
            else {
                double neededMoney = tripPrice - netRevenew;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");

            }
        }
    }
}
