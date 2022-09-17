using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            GetUserNameAndLocation();

            DateTime TodaysDate = DateTime.Now;
            ChristmasCountdown(TodaysDate);

            GlazerApp.RunExample();

            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();
        }

        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();

            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();

            Console.WriteLine($"I have never been to {person.location}. I bet it is nice.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private static void ChristmasCountdown(DateTime thisDate)
        {
            Console.WriteLine($"Today's date is: {thisDate}");

            DateTime christmasDate = Convert.ToDateTime("12/25/2022");
            DateTime TodayDate = Convert.ToDateTime(thisDate);

            double numberOfDays = (christmasDate - TodayDate).TotalDays;
            int daysTilChristmas = (int)numberOfDays;

            Console.WriteLine($"There are {daysTilChristmas} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
