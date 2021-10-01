using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int n = int.Parse(Console.ReadLine());
            do
            {
                n = n / 2;
                k++;
            } while (n != 0);
            Console.WriteLine(k - 1);
        }
    }
}
