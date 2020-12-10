using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace my_first_homework
{
    static class MathFunctions
    {
        public static void Output()
        {
            Console.WriteLine("Эта программа считает значение следующей функции \n " +
                "y = ((e^a+4*lg(c))/b^(1/2))*|arctg(d)|+5/sin(a)\n," +
                "где b=2001, c=8, d=30 \n");
            Thread.Sleep(50);
            Console.WriteLine("Введи значени \"а\"");
            int.TryParse(Console.ReadLine(), out int a);

            int b = 2001;
            int c = 8;
            int d = 30;
            double result = Function(a, b, c, d);
            Console.WriteLine($"Результат был: {result}");
        }

        public static double Function(int a, int b, int c, int d)
        {
            double first = (Math.Exp(a) + Math.Log10(c)) / Math.Sqrt(b);
            double second = Math.Abs(Math.Atan(d));
            double third = 5 / Math.Sin(a);
            return first * second + third;
        }
    }
}
