using System;

namespace depositeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the ammount");
            double deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the deposit period in months");
            int period = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the yearly interest");
            double yearlyInterestRate = double.Parse(Console.ReadLine());
            yearlyInterestRate = yearlyInterestRate / 100;
            double yearlyInterest = deposit * yearlyInterestRate;
            double monthlyInterest = yearlyInterest / 12;
            double ammount = deposit + monthlyInterest*period;
            Console.WriteLine(ammount);
        }
    }
}
