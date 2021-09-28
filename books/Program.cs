using System;

namespace books
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of pages in a book");
            int pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the pages per hour");
            int pagesPerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the days to finish the book");
            int days = int.Parse(Console.ReadLine());

            int totalTime = pages / pagesPerHour;


            int result= totalTime/days;
            Console.WriteLine(result);
        }
    }
}
