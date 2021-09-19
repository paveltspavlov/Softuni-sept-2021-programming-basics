using System;

namespace depositeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the ammount");
            double deposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the deposit period");
            int period = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the yearly interest");
            double interestRate = double.Parse(Console.ReadLine());
            double interestAmmount = deposit / interestRate*100;
            double monthlyInterest = interestAmmount / 12;
            double ammount = deposit + period * monthlyInterest;
            Console.WriteLine(ammount);
        }
    }
}



//percentage = (yourNumber / totalNumber) * 100;