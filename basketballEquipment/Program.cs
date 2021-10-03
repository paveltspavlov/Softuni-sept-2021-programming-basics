using System;

namespace basketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please isert the yearly fee:");
            int yearly = int.Parse(Console.ReadLine());

            double sneakers = yearly * 0.6;
            double outfit = sneakers * 0.8;
            double ball = outfit * 0.25;
            double accessories = ball * 0.2;

            double expenses = sneakers + outfit + ball + accessories + yearly;
            Console.WriteLine(expenses);

        }
    }
}
