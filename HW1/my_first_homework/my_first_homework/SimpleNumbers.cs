using System;
using System.Collections.Generic;
using System.Text;

namespace my_first_homework
{
    static class SimpleNumbers
    {
        public static void Output()
        {
            Console.WriteLine("Пользователь вводит границы диапазона для поиска простых чисел.Программа выводит найденные числа.");
            Console.Write("Введите начало диапазона : ");
            int.TryParse(Console.ReadLine(), out int begin);
            Console.Write("Введите конец диапазона : ");
            int.TryParse(Console.ReadLine(), out int end);
            CountNumbers(begin, end);
        }
        public static void CountNumbers(int begin,int end)
        {
            for (int i = begin; i <= end; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    Console.Write("{0}\t ", i);
                }
            }
        }
    }
}
