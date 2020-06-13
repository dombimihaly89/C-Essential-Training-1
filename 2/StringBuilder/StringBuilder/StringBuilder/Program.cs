using System;
using System.Text;

namespace StringBuilderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("World.");
            Console.WriteLine(sb);
            Console.WriteLine();

            // This way appendline doesn't good because it appends then starts a new line. So we have to use at the "hello" text too.
            var sb2 = new StringBuilder("Helllooo");
            sb2.AppendLine("Woooooorld");
            Console.WriteLine(sb2);
            Console.WriteLine();

            // This way it is going to be what we expected.
            var sb3 = new StringBuilder();
            sb3.AppendLine("Haloooo");
            sb3.AppendLine("Wooorld");
            Console.WriteLine(sb3);
        }
    }
}
