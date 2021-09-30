using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, m;
            char smv = 'N';
            Console.WriteLine("Задание 1");
            for (i = -100; i <= 50; i = i + 5)
            {
                Console.WriteLine(i + "");
            }
            Console.WriteLine("Задание 2");
            n = 0;
            while (n <= 5)
            {
                n += 1;
                Console.WriteLine(smv + "");
                smv++;

            }                                                       
            Console.WriteLine("Задание 3");
            {
                n = 5;
                m = 4;
                for (n = 0; n <= 5; n++)
                {
                    for (m = 0; m <= 4; m++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }
             Console.WriteLine("Задание 4");
                for (i = 0; i <= 100; i++)
                {
                    if (i == 0) continue;
                    if ((i % 7) != 0) continue;
                    Console.WriteLine(i + "");
                }


            }
        }
    }
}
