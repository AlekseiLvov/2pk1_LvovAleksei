using System;
using System.Linq;
using System.Threading;

namespace pz_12
{
    class Program
    {
        static void Main()
        {
            string[] str = new string[5];
            str[0] = "Как хорошо летом на море!";
            str[1] = "Лето - это отдых!";
            str[2] = "Лодку Василия отнесло на другой берег реки.";
            str[3] = "Холодно.";
            str[4] = "Хомяки спали весь день.";

            var res = str.OrderBy(t => t.Length);

            foreach (string item in res)
                Console.WriteLine(item);
        }
    }
 }

