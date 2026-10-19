//***********************************************************
//* Практичсекая работа № 5                                 *
//* Выполнила: Трухина Е.Д., группа 2ИСП                    *
//* Задание: составить программу разветвляющейся структуры  *
//*********************************************************** 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Title = "Практическая работа 5";
            Console.ForegroundColor = ConsoleColor.White;

            double N;

            Console.WriteLine("Здравствуй!");
            Console.Write("Введите N = ");
            N = Convert.ToDouble(Console.ReadLine());

            //Берем модуль числа, чтобы проверять и отрицательные значения
            double absN = Math.Abs(N);

            //Проверяем диапазон от 1000 до 9999 (по модулю)
            if (absN >= 1000 && absN <= 9999)
            {
                //Проверяем остаток от деления модуля на 2
                if (absN % 2 == 0)
                    Console.WriteLine("Число " + N + " является четным четырехзначным.");
                else
                    Console.WriteLine("Число " + N + " не является четным, но является четырехзначным.");
            }
            else
                Console.WriteLine("Число " + N + " не является четырехзначным.");

            Console.ReadKey();
        }
    }
}
