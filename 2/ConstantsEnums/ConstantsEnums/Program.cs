using System;

namespace ConstantsEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            const float num = 3.14f;
            Console.WriteLine(weekDays.Monday);

        }
    }

    enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday };
    enum weekDays2 { Monday = 1, Tuesday, Wednesday, Thursday, Friday };


}
