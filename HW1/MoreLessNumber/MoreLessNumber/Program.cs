using System;

namespace MoreLessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1ое число: ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("Введите 2ое число: ");
            int.TryParse(Console.ReadLine(), out int y);
            Random random = new Random();
            int k = random.Next(x, y);
            int count = 0;
            string str;

            Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);

            do
            {
                Console.Write("Ваш вариант: ");
                str = Console.ReadLine();

                if (int.Parse(str) < k)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(str) > k)
                    Console.WriteLine("Задуманное число меньше");

                count++;
            }
            while (int.Parse(str) != k);

            Console.WriteLine("Вы угадали с {0} попытки", count);
            int n = GetN(x, y);
            Console.WriteLine($"Количество Ваших очков: {Math.Ceiling(100.0*(n-count)/n)}");
            Console.ReadKey();
        }
        public static int GetN(int x, int y)
        {
            int d = (y-x+1);
            int pow = 0;
            while (d > 0)
            {
                d <<= 1;
                pow++;
            }
            pow--;
            return pow;
        }
    }
}
