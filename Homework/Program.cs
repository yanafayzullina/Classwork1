using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);


            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Введите два целых числа");
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (y != 0)
            {
                Console.WriteLine(x/y); }
            else
            { Console.WriteLine("Ошибка, на ноль делить нельзя"); }


            Console.WriteLine("Домашняя работа 2.1");
            char bukovka = Console.ReadKey().KeyChar;
            char letter = char.ToLower(bukovka);
            char nextBukovka;
            if (letter == 'z')
            {
                nextBukovka = 'a';
            }
            else
            {
                nextBukovka = (char)(((int)letter) + 1);
            }
            Console.WriteLine();
            Console.WriteLine("{0}", nextBukovka);


            Console.WriteLine("Домашняя работа 2.2");
            Console.WriteLine("Введите коэффициенты квадратного уравнения");
            double а = Convert.ToDouble(Console.ReadLine());
            double б = Convert.ToDouble(Console.ReadLine());
            double с = Convert.ToDouble(Console.ReadLine());
            double d = б * б - 4 * а * с;
            if (d >= 0)
            {
                double k = Math.Sqrt(d);
                double x1 = (-б + k) / (2 * а);
                double x2 = (-б - k) / (2 * а);
                Console.WriteLine(x1 + " " + x2);
            }
            else
            { Console.WriteLine("У уравнения нет корней"); }
            

            



            Console.ReadKey();
        }
    }
}