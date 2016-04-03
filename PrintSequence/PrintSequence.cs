using System;


namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int[] a = new int[] { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11 };
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(a[i]);
                i++;
            }
        }
    }
}
