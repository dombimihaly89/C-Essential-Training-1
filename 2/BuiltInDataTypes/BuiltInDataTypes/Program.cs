using System;

namespace BuiltInDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // These variables are primitives.

            var FirstString = "test 123";

            char firstChar = 'A';
            var secondChar = 'B';

            int firstInt = 5;
            var secondInt = 10;

            // This is a signed int. It can have negative values as well.
            int bigInt = int.MaxValue;

            // This is an unsigned int so it cannot have negative numbers but it is double the size of the normal int.
            uint bigPositiveInt = uint.MaxValue;

            // These types below also have the MaxValue constant and also have the unsigned version with the 'u' prefix.
            short smallerNumber = 5;

            long biggerNumber = 123412341234234;

            float pi = 3.14f;
            var pi2 = 3.14f;

            double pi3 = 3.14;
            var pi4 = 3.14d; // you don't need that 'd' here but you can put it there.

            bool personalTruth = true;
            var thisIsFalse = false;
            Console.WriteLine(personalTruth);
            Console.ReadLine();
        }
    }
}
