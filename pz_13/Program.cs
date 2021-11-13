using System;

namespace pz_13
{
    class Program
    {
        enum grades
        {
            Verybad = 1, Bad = 2, Notbad = 3, Good = 4, Great = 5,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите отметку: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch ((grades)num)
            {
                case grades.Verybad:
                    Console.WriteLine("Очень плохо");
                    break;
                case grades.Bad:
                    Console.WriteLine("Плохо");
                    break;
                case grades.Notbad:
                    Console.WriteLine(" Неплохо");
                    break;
                case grades.Good:
                    Console.WriteLine("Хорошо");
                    break;
                case grades.Great:
                    Console.WriteLine("Отлично");
                    break;

            }
        }
    }
}
