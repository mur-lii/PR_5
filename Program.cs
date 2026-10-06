//***********************************************************
//* Практичсекая работа № 5                                 *
//* Выполнила: Трухина Е.Д., группа 2ИСП                    *
//* Задание: составить программу разветвляющейся структуры  *
//*********************************************************** 
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            if ((N >= -9999) & (N <= 9999))
            {
                if (N % 2 == 0)
                    Console.WriteLine("Число является четным четырехзначным.");
                else
                    Console.WriteLine("Число не является четным, но является четырехзначным");
            }
            else
                Console.WriteLine("Число не является четырехзначным");

            Console.ReadKey();

        }
    }
}
