using System;

namespace StringFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = "Dallas";
            var temperature = 103.4f;
            var currentDt = DateTime.Now;

            var welcomeMessage = string.Format("Welcome to {0}. The time is {1}. And it is {2} degrees.", city, currentDt, temperature);
            Console.WriteLine(welcomeMessage);

            // But we can format it like this. We can see the formatting options in the documentation.
            var welcomeMessage2 = string.Format("Welcome to {0}. The time is {1:t}. And it is {2:0.00} degrees.", city, currentDt, temperature);
            Console.WriteLine(welcomeMessage2);

            temperature = 1000.23f;
            var welcomeMessage3 = string.Format("Welcome to {0}. The time is {1:t}. And it is {2:0,0.00} degrees.", city, currentDt, temperature);
            Console.WriteLine(welcomeMessage3);

        }
    }
}
