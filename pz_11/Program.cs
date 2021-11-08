using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 25;
            String S = "Преобразовать строку";
            if (S.Length > N)
                S = S.Substring(S.Length - N, N);
            else
                S = new string('.', N - S.Length) + S;
            Console.WriteLine(S);
            Console.ReadLine();
        }
    }
}
