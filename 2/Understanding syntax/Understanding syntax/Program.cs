﻿using System;

namespace Understanding_syntax
{
    class Program
    {
        public static string title = "C# Essential Training";
        public static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}!", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("Press the enter key to exit");
            Console.ReadLine();
        }
    }
}
