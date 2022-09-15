// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            //3
            Console.WriteLine($"Your name is {name} and you are from {location}");

            //4
            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToLongDateString()}");

            //5
            var christmas = new DateTime(currentDate.Year, 12, 25);
            var daysUntilChristmas = christmas.Subtract(currentDate);
            Console.WriteLine($"There are {daysUntilChristmas.Days} days until christmas");

            //6

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Welcome to glass area calculator!");

            Console.Write("Please enter the width of the window in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of the window in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");



            //7
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
