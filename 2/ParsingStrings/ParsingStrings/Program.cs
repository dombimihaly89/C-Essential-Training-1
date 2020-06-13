using System;

namespace ParsingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse("15");
            Console.WriteLine(num1);

            // This isn't going to work.
            // int num2 = int.Parse("15,34");

            var test = "15,234";
            int num3 = int.Parse(test.Replace(",", ""));
            Console.WriteLine(num3);

            // Tryparse returns a boolean, and if it is succeeding then it gives the parsed string, so the number to the out parameter.
            int theResult;
            bool isSucceed = int.TryParse("15345", out theResult);
            Console.WriteLine("The result is : " + theResult);
            Console.WriteLine("Succeeded? " + isSucceed);



        }
    }
}
