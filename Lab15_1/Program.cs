using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    class Program
    {
        static void TestArithProgression()
        {
            Console.Write("Введите первый член прогрессии: ");
            int init = int.Parse(Console.ReadLine());
            Console.Write("Введите шаг прогрессии: ");
            int step = int.Parse(Console.ReadLine());
            Console.Write("Введите начальную позицию в прогрессии: ");
            int pos = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат:");

            ArithProgression ap = new ArithProgression(init, step);
            ap.setStart(pos);

            for (int i = 0; i < 10; i++)
                Console.Write($"{ap.getNext()} ");
            Console.WriteLine();
            ap.reset();

            for (int i = 0; i < 10; i++)
                Console.Write($"{ap.getNext()} ");
            Console.WriteLine();

            Console.ReadKey();
        }

        static void TestGeomProgression()
        {
            Console.Write("Введите первый член прогрессии: ");
            int init = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель прогрессии: ");
            int step = int.Parse(Console.ReadLine());
            Console.Write("Введите начальную позицию в прогрессии: ");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");

            GeomProgression ap = new GeomProgression(init, step, pos);

            for (int i = 0; i < 10; i++)
                Console.Write($"{ap.getNext()} ");
            Console.WriteLine();
            ap.reset();

            for (int i = 0; i < 10; i++)
                Console.Write($"{ap.getNext()} ");
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит первые 10 членов прогресии");
        begin:
            Console.WriteLine("Укажите нужный тип прогрессии:\n  1 - арифметическая\n  2 - геометрическая\n  3 - выход");

            switch (Console.ReadLine())
            {
                case "1": TestArithProgression(); break;
                case "2": TestGeomProgression(); break;
                case "3": return;
                default:
                    Console.WriteLine("Неверный ввод");
                    goto begin;
            }
        }
    }
}
