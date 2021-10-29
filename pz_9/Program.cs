using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, sum1 = 0, sum2 = 0;
            Console.WriteLine("Введите количество строк: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] k = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    k[i, j] = r.Next(0, 100);
                    Console.Write("{0} ", k[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum1 += k[i, j];
                }
                Console.WriteLine();
                Console.WriteLine("Сумма " + (i + 1) + " = " + sum1);
                sum1 = 0;
            }
            Console.WriteLine();
        }
    }
}
