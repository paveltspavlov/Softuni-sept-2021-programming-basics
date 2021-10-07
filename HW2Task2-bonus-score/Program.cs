using System;

namespace HW2Task2_bonus_score
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingScore = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            double finalScore = 0;

            if (startingScore <= 100)
            {
                bonusPoints = 5;
            }
            else if (startingScore > 100 && startingScore <= 1000) {
                
                bonusPoints = startingScore * 0.2 ; 
            }
            else if (startingScore > 1000)
            {
                bonusPoints = startingScore * 0.1;
            }

            if (startingScore % 2==0)
            {
               
                bonusPoints = bonusPoints + 1;
             }
            else if (startingScore % 10==5)
            {
               
                bonusPoints = bonusPoints+2;
            }
            finalScore = startingScore+bonusPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(finalScore);

        }
    }
}
