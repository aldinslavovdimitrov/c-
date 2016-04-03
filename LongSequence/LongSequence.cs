using System;

namespace LongSequence
{
    class LongSequence

    {
        static void Main()
        {
            int a = 0;
            int i = 2;
            while (a < 500)
            {
                Console.WriteLine(i);
                i++;
                Console.WriteLine(i*-1);
                i++;
                a++;
            }
        }
    }
}
