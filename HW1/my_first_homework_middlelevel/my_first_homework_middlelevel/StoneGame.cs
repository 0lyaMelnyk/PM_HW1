using System;
using System.Collections.Generic;
using System.Text;

namespace my_first_homework_middlelevel
{
    static class StoneGame
    {
        public static void Play()
        {
            Random random = new Random();

            String[] items = new String[3];
            items[0] = "Камень";
            items[1] = "Ножницы";
            items[2] = "Бумага";
            string youwin = "Ты выиграл.";
            string youlose = "Ты проиграл.";
            string youdraw = "Ничья.";
            int coincidental = random.Next(items.Length);
            string coincidental2 = items[coincidental];
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Камень");
                Console.WriteLine("2.Ножницы");
                Console.WriteLine("3.Бумага");
                Console.WriteLine("4.Exit");
                Console.Write("Твой выбор ? — ");
                int Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Камень vs {0}", coincidental2);

                        if (coincidental2 != items[0] && coincidental2 != items[2])
                            Console.WriteLine(youwin);
                        else if (coincidental2 != items[0] && coincidental2 != items[1])
                            Console.WriteLine(youlose);
                        else
                            Console.WriteLine(youdraw);

                        break;
                    case 2:
                        Console.WriteLine("Ножницы vs {0}", coincidental2);

                        if (coincidental2 != items[1] && coincidental2 != items[0])
                            Console.WriteLine(youwin);
                        else if (coincidental2 != items[1] && coincidental2 != items[2])
                            Console.WriteLine(youlose);
                        else
                            Console.WriteLine(youdraw);
                        break;
                    case 3:
                        Console.WriteLine("Бумага vs {0}", coincidental2);
                        if (coincidental2 != items[2] && coincidental2 != items[1])
                            Console.WriteLine(youwin);
                        else if (coincidental2 != items[2] && coincidental2 != items[0])
                            Console.WriteLine(youlose);
                        else
                            Console.WriteLine(youdraw);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
