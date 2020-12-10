using System;
using System.Threading;

namespace my_first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! It`s my first homework in PariMatch academy!\n" +
                "If you would prefer my solutions input number of task");
            Console.WriteLine("|\n|\n|\n");
            int.TryParse(Console.ReadLine(), out int value);
            switch (value)
            {
                case 1:
                    MathFunctions.Output();
                    break;
                case 2:
                    Margin.Output();
                    break;
                case 3:
                    Sum.Output();
                    break;
            }
            Console.ReadKey();

        }
    }
}
