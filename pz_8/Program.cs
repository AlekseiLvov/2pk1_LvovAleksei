using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] A = new int[n];
            Random rnd = new Random();
            int rndnumber;
            double aver = 0.0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(100);
                if (A[i] < min)
                    min = A[i];
                if (A[i] > max)
                    max = A[i];
                rndnumber = rnd.Next(1, 10);
                A[i] = rndnumber;
                aver += A[i] / (double)A.Length;
            }
            Console.WriteLine("Сумма чисел массива: {0}", min + max);
            Console.WriteLine("Произведение чисел массива: {0}", min * max);
            Console.WriteLine("Среднее арифметическое: {0}", aver);
            Console.ReadLine();
        }

    }      
}
