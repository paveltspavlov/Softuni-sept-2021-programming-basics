using System;

namespace foodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please isert quantity of chicken menus:");
            int chickenMenu = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert quantity of fish menus:");
            int fishMenu = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert quantity of vegeterian menus:");
            int vegeterianMenu = int.Parse(Console.ReadLine());

            double deliveryFee = 2.5;

            double chickenOrder = chickenMenu * 10.35;
            double fishOrder = fishMenu * 12.4;
            double vegeterianOrder = vegeterianMenu * 8.15;
            double order = chickenOrder + fishOrder + vegeterianOrder;
            double desert = order * 0.2;

            double finalOrder = deliveryFee + order + desert;

            Console.WriteLine(finalOrder);

        }
    }
}
