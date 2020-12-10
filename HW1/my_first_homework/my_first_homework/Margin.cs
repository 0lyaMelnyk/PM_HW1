using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace my_first_homework
{
    static class Margin
    {
        public static void Output()
        {
            Console.WriteLine("Hi! Эта программа считает маржу букмекера\n" +
                " Введи названия учасников:");
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            Console.WriteLine("Введи коефициенты :\nП1 ");
            Thread.Sleep(50);
            double.TryParse(Console.ReadLine(), out double w1);
            Console.WriteLine("Х");
            double.TryParse(Console.ReadLine(), out double d);
            Console.WriteLine("П2");
            double.TryParse(Console.ReadLine(), out double w2);
            Console.WriteLine($"Победа “{firstName}” : {1/w1}%\n" +
                $"Победа “{secondName}” : {1/w2}%\n" +
                $"Ничья : {1/d}%\n" +
                $"Маржа букмекера : {CountMargin(w1,d,w2)}%\n" +
                $"(c)Created by Olya Melnyk");
        }
        public static double CountMargin(double w1, double d, double w2)
        {
            return 1 - 1 / (1 / w1 + 1 / d + 1 / w2);
        }
    }
}
