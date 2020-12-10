using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace my_first_homework
{
    static class Sum
    {
        public static void Output()
        {
            const decimal epsilon = 1 / 2001;
            Console.WriteLine("Рассчитать сумму заданного ряда. Закончить подсчет на элементе, который меньше чем epsilon, где epsilon = (1 / 2001)\n" +
                "Sum(i=1,infinity)=1/(i*(1+i))\n" +
                $"epsilon={epsilon}");
            Thread.Sleep(50);
            Console.WriteLine($"Результат: {CountSum(epsilon)}\n" +
                "(c)Created by Olya Melnyk");
        }
        public static decimal CountSum(decimal epsilon)
        {
            decimal result = 0.5M;
            for(int i=2; result>epsilon; i++)
            {
                result += 1 / (1 * (1 + i));
            }
            return result;
        }
    }
}
