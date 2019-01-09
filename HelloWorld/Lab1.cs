using System;

namespace HelloWorld
{
    class Lab1
    {
        public static void Run()
        {
            string key = "0";

            do
            {
                Console.Write("Введите номер задачи для её запуска (0 - назад): ");
                key = Console.ReadLine();

                switch (key)
                {
                    case "0": break;
                    case "1": Lab1Task1(); break;
                    case "2": Lab1Task2(); break;
                    case "3": Lab1Task3(); break;
                    default:
                        Console.WriteLine("Извините, но такой задачи в этой лаб. работе нет.");
                        break;
                }
            } while (key != "0");
        }

        //Задача 1
        private static void Lab1Task1()
        {
            //первые 3 пункта предполагают работу с одним и тем же набором переменных. Занесём код в метод внтури цикла.
            for (int i = 1; i <= 3; i++) Lab1Task1Point1(i);

            Console.WriteLine("Пункт 4.");

            Console.Write("x? ");
            float x;
            if (float.TryParse(Console.ReadLine(), out x))
            {
                float check = (float)Math.Pow(x, 3) - x;

                //проверка на деление на ноль
                if (check == 0)
                    Console.WriteLine("Вычисление невозможно");
                else
                {
                    float result3 = x + 1 / check - 2;
                    Console.WriteLine($"x={x} x + (1/(x ^ 3 - x)) - 2 = {result3}");
                }
            }
            else Console.WriteLine("Это не число.");
        }

        //Пункт 1
        private static void Lab1Task1Point1(int i)
        {
            bool correct = true;

            Console.WriteLine($"Пункт {i}.");

            Console.Write("m? ");
            int m;
            if (int.TryParse(Console.ReadLine(), out m))
                Console.Write("n? ");
            else
                correct = false;

            int n;
            if (correct && int.TryParse(Console.ReadLine(), out n))
                switch (i)
                {
                    case 1:
                        int result = ++n * ++m;
                        Console.WriteLine($"m={m} n={n} ++n * ++m={result}");
                        break;
                    case 2:
                        bool result2 = m++ < n;
                        Console.WriteLine($"m={m} n={n} m++ < n={result2}");
                        break;
                    case 3:
                        result2 = n++ > m;
                        Console.WriteLine($"m={m} n={n} n++ > m={result2}");
                        break;
                }
            else Console.WriteLine("Это не целое число.");
        }

        //Задача 2
        private static void Lab1Task2()
        {
            bool correct = true;

            Console.Write("x? ");
            float x;
            if (float.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("y? ");
            }
            else
            {
                correct = false;
            }

            float y;
            if (correct && float.TryParse(Console.ReadLine(), out y))
            {
                bool result = (x >= -7) && (x <= 0) && (y <= 0) && (y >= -1);

                if (result)
                {
                    Console.WriteLine($"Точка ({x}, {y}) принадлежит заштрихованной области");
                }
                else
                {
                    Console.WriteLine($"Точка ({x}, {y}) не принадлежит заштрихованной области");
                };
            }
            else
            {
                Console.WriteLine($"Не удалось распознать аргументы. Перезапустите задачу.");
            }
        }

        //Задача 3
        private static void Lab1Task3()
        {
            decimal a = 1000;
            decimal b = 0.0001M;

            decimal c = (a - b) * (a - b); // (a - b) ** 2
            decimal d = a * a - 2 * a * b; // (a ** 2 - 2ab)

            float res = (float)((c - d) / (b * b)); //в знаменателе нуля не будет

            Console.WriteLine($"При a = {a} и b = {b}, результат равен {res}");
        }
    }
}
