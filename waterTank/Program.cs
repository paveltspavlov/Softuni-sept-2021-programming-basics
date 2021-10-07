using System;

namespace waterTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please einter the lenght of the aquarium:");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Please einter the width of the aquarium:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please einter the hight of the aquarium:");
            int hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please einter the percent of sand:");
            double sandPercent = double.Parse(Console.ReadLine());

            double capacity = lenght * width * hight;
            double aquariumCapacityInLiters = capacity / 1000;
            double sandQuantity = sandPercent / 100;
            double neededWater = aquariumCapacityInLiters*(1-sandQuantity);
            Console.WriteLine(neededWater);

        }
    }
}
