using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            var birthDay = new DateTime(1989, 3, 7);
            
            // This code below gives you back a TimeSpan object.
            var difference = DateTime.Now - birthDay;
            Console.WriteLine(difference.Days);

            Console.WriteLine("I'm living for " + (difference.Days / 365) + " years.");

            var someTime = new DateTime(2020, 6, 27, 12, 45, 32);
            Console.WriteLine(someTime.AddMinutes(120));

            Console.WriteLine(someTime.ToFileTime());
            Console.WriteLine(someTime.ToLongDateString());

        }
    }
}
