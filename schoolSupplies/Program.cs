using System;

namespace schoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Please isert number of pens you want:");
            int penPackages = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert number of sharpies you want:");
            int numberOfSharpys = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert the litres of cleaner you want:");
            int LitresOfCleaner = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert the discount percent:");
            int discountPercent = int.Parse(Console.ReadLine());

            double pricePens = penPackages  * 5.8;
            double priceSharpy = numberOfSharpys * 7.2;
            double priceCleaner = LitresOfCleaner * 1.2;
            double price1 = priceCleaner + pricePens + priceSharpy;
            double discount = discountPercent / 100.00;
            double price = discount * price1;
            double finalPrice = price1 - price;
            Console.WriteLine(finalPrice);
        }
    }
}
