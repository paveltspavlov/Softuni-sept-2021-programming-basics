using System;

namespace godzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double clothesPerOneStatist = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double discount;
            double overTheBudget;
            

            double noDiscountClothes = statisti * clothesPerOneStatist;
            double totalCostOfClothes;

            if (statisti > 150)
            {
                discount = noDiscountClothes * 0.1;
                totalCostOfClothes = noDiscountClothes - discount;

            }
            else {
                totalCostOfClothes = noDiscountClothes;
            }

            double buff = decor + totalCostOfClothes;

            if (buff > budget)
            {
                overTheBudget = buff - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {overTheBudget:f2} leva more.");
            }
            else if(buff < budget)
            {
                overTheBudget = budget- buff;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {overTheBudget:f2} leva left.");
            }
            
        }
    }
}
