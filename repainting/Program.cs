using System;

namespace repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please isert quantity of plastic wrap:");
            int wrap = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert the paint quantity:");
            int paint = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert the litres of thinner you want:");
            int thinner = int.Parse(Console.ReadLine());
            Console.WriteLine("Please isert the total hours to finish the work:");
            int hours = int.Parse(Console.ReadLine());
            double bags = 0.4;
            double paintQuantity = paint * 1.1;
            double totalWrap = (wrap+2) * 1.5;
            double totalPaint = paintQuantity * 14.5;
            double totalThinner = thinner * 5.00;
            double price1 = totalWrap + totalPaint + totalThinner + bags;
            double priceForHour = price1 * 0.3;
            double priceForWork = priceForHour * hours;
            double finalPrice = price1 + priceForWork;
            Console.WriteLine(finalPrice);
        }
    }
    
}
