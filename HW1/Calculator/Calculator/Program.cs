using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Введите число фигуры, а после введите параметры");
            while (flag)
            {
                Console.WriteLine("1.rect(a,b)\n2.circle(r)\n3.square(a)\n4.triangle(a,b,c)\n5.exit");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("a =");
                        int.TryParse(Console.ReadLine(), out int a);
                        Console.WriteLine("b =");
                        int.TryParse(Console.ReadLine(), out int b);
                        Console.WriteLine(a*b);
                        break;
                    case 2:
                        Console.WriteLine("r =");
                        int.TryParse(Console.ReadLine(), out int r);
                        Console.WriteLine(Math.PI*r*r);
                        break;
                    case 3:
                        Console.WriteLine("а =");
                        int.TryParse(Console.ReadLine(), out int c);
                        Console.WriteLine(c*c);
                        break;
                    case 4:
                        Console.WriteLine("a =");
                        int.TryParse(Console.ReadLine(), out int d);
                        Console.WriteLine("b =");
                        int.TryParse(Console.ReadLine(), out int e);
                        Console.WriteLine("c =");
                        int.TryParse(Console.ReadLine(), out int f);
                        double p = d/2.0+ e /2.0+ f / 2.0;
                        Console.WriteLine(Math.Sqrt(p*(p-d)*(p-e)*(p-f)));
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Введите коректное значение");
                        break;
                }
            }
        }
    }
}
